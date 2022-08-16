namespace SpiderManTextureTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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

        }

        private void selectTextureBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openTexture.ShowDialog())
            {
                Properties.Settings.Default.lastTexPath = openTexture.FileName;
                texturePathTxt.Text = openTexture.FileName;
            }

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

            System.Diagnostics.Process.Start("RawtexCMD.exe", $"{texturePathTxt.Text} {textureFormat} {texSize} {texSize}");

            if (saveToChk.Checked)
            {
                
            }
        }
    }
}