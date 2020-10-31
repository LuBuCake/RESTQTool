﻿using System.IO;
using System.Linq;

namespace RESTQTool
{
    public class STQ
    {
        private FileStream FS;
        private BinaryReader BR;
        private BinaryWriter BW;

        public string FileDir;
        public string Format;
        public int Version;
        public int NumSounds;

        public int Mode;
        private int Start;

        public int[] FileNamePos;
        public string[] FileName;
        public int[] FileSize;
        public int[] Duration;
        public int[] Channels;
        public int[] LoopStart;
        public int[] LoopEnd;

        private int[] SupportedVersions =
        {
            18, // RE5
            28, // RE6
            1,  // REV1
            2   // REV2
        };

        public STQ(string FilePath)
        {
            LoadSTQ(FilePath);
        }

        private void LoadSTQ(string FilePath)
        {
            FS = new FileStream(FilePath, FileMode.Open);
            BR = new BinaryReader(FS);

            FileDir = FilePath;

            for (int i = 0; i < 4; i++)
            {
                Format += (char)BR.ReadByte();
            }

            Version = BR.ReadInt32();
            NumSounds = BR.ReadInt32();

            FileNamePos = new int[NumSounds];
            FileName = new string[NumSounds];
            FileSize = new int[NumSounds];
            Duration = new int[NumSounds];
            Channels = new int[NumSounds];
            LoopStart = new int[NumSounds];
            LoopEnd = new int[NumSounds];

            switch(Version)
            {
                case 18:
                case 28:
                    Mode = 1; // RE5 or RE6
                    Start = 0x3C;
                    break;
                case 1:
                case 2:
                    Mode = 2; // REV1 or REV2
                    Start = 0x38;
                    break;
            }

            for (int i = 0; i < NumSounds; i++)
            {
                BR.BaseStream.Position = Start + ((Mode == 1 ? 0x18 : 0x24) * i);

                FileNamePos[i] = BR.ReadInt32();
                FileSize[i] = BR.ReadInt32();
                Duration[i] = BR.ReadInt32();
                Channels[i] = BR.ReadInt32();

                if (Mode == 1)
                {
                    LoopStart[i] = BR.ReadInt32();
                    LoopEnd[i] = BR.ReadInt32();
                }
                else
                {
                    BR.BaseStream.Position += 4; // Skip sample frequency (Should aways be 48000 Hz)

                    LoopStart[i] = BR.ReadInt32();
                    LoopEnd[i] = BR.ReadInt32();
                }
            }

            for (int i = 0; i < NumSounds; i++)
            {
                BR.BaseStream.Position = FileNamePos[i];

                for (int j = 0; j < (((i + 1) < NumSounds ? FileNamePos[i + 1] : FS.Length) - FileNamePos[i]); j++)
                {
                    FileName[i] += (char)BR.ReadByte();
                }
            }

            FS.Dispose();
            BR.Dispose();
        }

        public void SaveSTQ()
        {
            FS = new FileStream(FileDir, FileMode.Open);
            BW = new BinaryWriter(FS);

            for (int i = 0; i < NumSounds; i++)
            {
                BW.BaseStream.Position = 0x3C + (0x18 * i);

                BW.Write(FileNamePos[i]);
                BW.Write(FileSize[i]);
                BW.Write(Duration[i]);
                BW.Write(Channels[i]);
                BW.Write(LoopStart[i]);
                BW.Write(LoopEnd[i]);
            }

            FS.Dispose();
            BW.Dispose();
        }

        public void ReplaceData(int index, int filesize, int duration, int channels, int loopstart, int loopend)
        {
            FileSize[index] = filesize;
            Duration[index] = duration;
            Channels[index] = channels;
            LoopStart[index] = loopstart;
            LoopEnd[index] = loopend;
        }

        // Utils

        public bool CheckSTQ()
        {
            return (Format == "STRQ" || Format == "STQR") && SupportedVersions.Contains(Version);
        }
    }
}
