using System;
using System.Windows.Forms;

namespace RESTQTool
{
    public partial class Main : Form
    {
        // Globals

        private STQ WorkingSTQ;
        private string STQFilePath;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            STQFileNameBox.Text = "No STQ file opened";
        }

        // STQ Tools

        private bool CheckSTQ()
        {
            if (WorkingSTQ == null)
            {
                MessageBox.Show("No STQ file loaded.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }

        private void OpenSTQButton_Click(object sender, EventArgs e)
        {
            string STQNameSafe;

            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                OpenFile.Filter = "RE5 STQ files (*.stq)|*.stq";
                OpenFile.Title = "Select a valid STQ file";

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    STQFilePath = OpenFile.FileName;
                    WorkingSTQ = new STQ(STQFilePath);

                    if (!WorkingSTQ.CheckSTQ())
                    {
                        MessageBox.Show("This is not a valid STQ file.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        STQFilePath = "";
                        WorkingSTQ = null;
                        return;
                    }

                    STQNameSafe = OpenFile.SafeFileName;

                    if (STQNameSafe.Contains(".stq"))
                        STQNameSafe = STQNameSafe.Replace(".stq", "");

                    STQFileNameBox.Text = "STQ: " + STQNameSafe;

                    SoundComboBox.Items.Clear();

                    for (int i = 0; i < WorkingSTQ.NumSounds; i++)
                    {
                        SoundComboBox.Items.Add("FILE: " + i.ToString());
                    }

                    SoundComboBox.SelectedIndex = 0;
                }
            }
        }

        private void SaveSTQButton_Click(object sender, EventArgs e)
        {
            if (!CheckSTQ())
                return;

            WorkingSTQ.SaveSTQ();
            MessageBox.Show("STQ file updated!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void SoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkingSTQ == null)
                return;

            int index = SoundComboBox.SelectedIndex;

            SoundFileBox.Text = WorkingSTQ.FileName[index];

            FileSizeBox.Text = WorkingSTQ.FileSize[index].ToString();
            DurationBox.Text = WorkingSTQ.Duration[index].ToString();
            ChannelBox.Text = WorkingSTQ.Channels[index].ToString();
            LoopStartBox.Text = WorkingSTQ.LoopStart[index].ToString();
            LoopEndBox.Text = WorkingSTQ.LoopEnd[index].ToString();
        }

        private void ApplyDataButton_Click(object sender, EventArgs e)
        {
            if (!CheckSTQ())
                return;

            try
            {
                int filesize = int.Parse(FileSizeBox.Text);
                int duration = int.Parse(DurationBox.Text);
                int channels = int.Parse(ChannelBox.Text);
                int loopstart = int.Parse(LoopStartBox.Text);
                int loopend = int.Parse(LoopEndBox.Text);

                WorkingSTQ.ReplaceData(SoundComboBox.SelectedIndex, filesize, duration, channels, loopstart, loopend);

                MessageBox.Show("Data entry updated!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong data type, check your inputs.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
