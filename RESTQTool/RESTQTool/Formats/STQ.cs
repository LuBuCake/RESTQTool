/*
This file is part of RESIDENT EVIL XSEW Tool.

RESIDENT EVIL STQ Tool is free software: you can redistribute it
and/or modify it under the terms of the GNU General Public License
as published by the Free Software Foundation, either version 3 of
the License, or (at your option) any later version.

RESIDENT EVIL STQ Tool is distributed in the hope that it will
be useful, but WITHOUT ANY WARRANTY; without even the implied
warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with RESIDENT EVIL STQ Tool. If not, see <https://www.gnu.org/licenses/>6.
*/

using System.IO;
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

        public byte[] HeaderData;

        public int Mode;
        private int Start;

        public int[] FileNamePos;
        public string[] FileName;
        public int[] FileSize;
        public int[] Duration;
        public int[] Channels;
        public int[] SampleRate;
        public int[] LoopStart;
        public int[] LoopEnd;

        public byte[] UnknownData;

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

            int HeaderDataSize = (int)(Start - BR.BaseStream.Position);
            HeaderData = new byte[HeaderDataSize];
            HeaderData = BR.ReadBytes(HeaderDataSize);

            FileNamePos = new int[NumSounds];
            FileName = new string[NumSounds];
            FileSize = new int[NumSounds];
            Duration = new int[NumSounds];
            Channels = new int[NumSounds];
            SampleRate = new int[NumSounds];
            LoopStart = new int[NumSounds];
            LoopEnd = new int[NumSounds];

            for (int i = 0; i < NumSounds; i++)
            {
                FileNamePos[i] = BR.ReadInt32();
                FileSize[i] = BR.ReadInt32();
                Duration[i] = BR.ReadInt32();
                Channels[i] = BR.ReadInt32();

                if (Mode == 2)
                    SampleRate[i] = BR.ReadInt32();

                LoopStart[i] = BR.ReadInt32();
                LoopEnd[i] = BR.ReadInt32();
            }

            int UnknownDataSize = (int)(FileNamePos[0] - BR.BaseStream.Position);
            UnknownData = new byte[UnknownDataSize];
            UnknownData = BR.ReadBytes(UnknownDataSize);

            for (int i = 0; i < NumSounds; i++)
            {
                BR.BaseStream.Position = FileNamePos[i];

                for (int j = 0; j < (((i + 1) < NumSounds ? FileNamePos[i + 1] : FS.Length) - FileNamePos[i]) - 1; j++)
                {
                    FileName[i] += (char)BR.ReadByte();
                }
            }

            FS.Dispose();
            BR.Dispose();
        }

        public void SaveSTQ()
        {
            FS = new FileStream(FileDir, FileMode.Create);
            BW = new BinaryWriter(FS);

            BW.Write(Format.ToCharArray());
            BW.Write(Version);
            BW.Write(NumSounds);
            BW.Write(HeaderData);

            for (int i = 0; i < NumSounds; i++)
            {
                BW.Write(FileNamePos[i]);
                BW.Write(FileSize[i]);
                BW.Write(Duration[i]);
                BW.Write(Channels[i]);

                if (Mode == 2)
                    BW.Write(SampleRate[i]);

                BW.Write(LoopStart[i]);
                BW.Write(LoopEnd[i]);
            }

            BW.Write(UnknownData);

            for (int i = 0; i < NumSounds; i++)
            {
                BW.Write(FileName[i].ToCharArray());
                BW.Write((byte)0);
            }

            FS.Dispose();
            BW.Dispose();
        }

        public void ReplaceData(int index, string filename, int filesize, int duration, int channels, int loopstart, int loopend)
        {
            FileName[index] = filename;
            FileSize[index] = filesize;
            Duration[index] = duration;
            Channels[index] = channels;
            LoopStart[index] = loopstart;
            LoopEnd[index] = loopend;

            UpdateFileNamePositions();
        }

        private void UpdateFileNamePositions()
        {
            int BaseOffset = FileNamePos[0];
            int TempOffset = BaseOffset;

            for (int i = 1; i < NumSounds; i++)
            {
                TempOffset += FileName[i - 1].ToCharArray().Length + 1;
                FileNamePos[i] = TempOffset;
            }
        }

        // Utils

        public bool CheckSTQ()
        {
            return (Format == "STRQ" || Format == "STQR") && SupportedVersions.Contains(Version);
        }
    }
}
