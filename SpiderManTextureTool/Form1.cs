namespace SpiderManTextureTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public bool hasHeader = false;

        private void Main_Load(object sender, EventArgs e)
        {
            //Load default combo items
            textureSizeCmb.SelectedItem = textureSizeCmb.Items[0];
            textureFormatCmb.SelectedItem = textureFormatCmb.Items[6];

            //Load used paths
            texturePathTxt.Text = Properties.Settings.Default.lastTexPath;
            ddsPathTxt.Text = Properties.Settings.Default.lastDDSPath;

            //Check if RawTex CMD exist
            if (!File.Exists("RawtexCMD.exe"))
            {
                MessageBox.Show("No RawTex file found!");
            }

            //Status Label
            statusLbl.Text = "";

        }

        private void selectTextureBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openTexture.ShowDialog())
            {
                Properties.Settings.Default.lastTexPath = openTexture.FileName;
                texturePathTxt.Text = openTexture.FileName;
            }

            statusLbl.Text = "\u2716";
            statusLbl.ForeColor = Color.Red;

        }

        private void convertToDDSBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("RawtexCMD.exe"))
            {
                MessageBox.Show("No RawTex file found!");
                return;
            }

            var texSize = textureSizeCmb.SelectedItem.ToString() == "Auto" ? "" : textureSizeCmb.SelectedItem.ToString();
            var textureFormat = textureFormatCmb.SelectedItem.ToString()?.ToLower() ?? "bc7";
            var offset = 0x0;
            foreach(var a in File.ReadLines(texturePathTxt.Text))
                if (a.Contains("Texture") || a.Contains("Built") || a.Contains("File"))
                {
                    offset = 0x80;
                    hasHeader = true;
                    break;
                }
            var param = $"\"{texturePathTxt.Text}\" {textureFormat} {offset} {texSize} {texSize}".Trim();
            System.Diagnostics.Process.Start("RawtexCMD.exe", param);

            if (saveToChk.Checked)
            {
                try
                {
                    var ddsLocation = Path.ChangeExtension(texturePathTxt.Text, "dds");
                    var ddsName = Path.GetFileName(ddsLocation);
                    if (DialogResult.OK == saveDDS.ShowDialog())
                    {
                        string saveTo = Path.Combine(saveDDS.SelectedPath, ddsName);
                        File.Move(ddsLocation, saveTo);
                        ddsPathTxt.Text = saveTo;
                    }
                }
                catch
                {
                    MessageBox.Show("Could not move dds to specified folder");
                }
            }
            statusLbl.Text = "\u2714";
            statusLbl.ForeColor = Color.Green;
        }

        private void texturePathTxt_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void selectDDSBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openDDS.ShowDialog())
            {
                Properties.Settings.Default.lastDDSPath = openDDS.FileName;
                ddsPathTxt.Text = openDDS.FileName;
            }
        }

        private void convertDDSBtn_Click(object sender, EventArgs e)
        {
            //replace 94 dds lines with 70 texture lines
            //match dd's last byte size to texture 
            //save as .texture

            var p = ddsPathTxt.Text;
            var t = texturePathTxt.Text;

            var ddsBytes = File.ReadAllBytes(p);
            var texBytes = File.ReadAllBytes(t);

            //skip 0x94 bytes from start
            ddsBytes = ddsBytes.Skip(Convert.ToByte(0x94)).ToArray();
            var headerBytes = hasHeader ? texBytes.SkipLast(0x80).ToArray() : new byte[0];

            var combine = headerBytes.Concat(ddsBytes);
            var result = combine.SkipLast(combine.);


        }
    }
}