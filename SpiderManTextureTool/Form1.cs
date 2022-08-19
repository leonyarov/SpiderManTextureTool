using System.Net.Http.Headers;

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
            var dialogRes = batchChk.Checked ? batchTexture.ShowDialog() : openTexture.ShowDialog() ;
            if (DialogResult.OK == dialogRes)
            {
                texturePathTxt.Text = batchChk.Checked ? batchTexture.SelectedPath : openTexture.FileName;
                ddsPathTxt.Text = batchChk.Checked ? batchTexture.SelectedPath : Path.ChangeExtension(openTexture.FileName, ".dds");
            }

            statusLbl.Text = "\u2716";
            statusLbl.ForeColor = Color.Red;

        }

        private void convertToDDSBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(texturePathTxt.Text))
            {
                MessageBox.Show("Texture path is empty!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists("RawtexCMD.exe"))
            {
                MessageBox.Show("No RawTex file found!");
                return;
            }

            var texSize = textureSizeCmb.SelectedItem.ToString() == "Auto"
                ? ""
                : textureSizeCmb.SelectedItem.ToString();
            var textureFormat = textureFormatCmb.SelectedItem.ToString()?.ToLower() ?? "bc7";
            var offset = 0x0;

            //foreach(var a in File.ReadLines(texturePathTxt.Text))
            //    if (a.Contains("Texture") || a.Contains("Built") || a.Contains("File"))
            //    {
            //        MessageBox.Show("Has Header");
            //        offset = 0x80;
            //        hasHeader = true;
            //        break;
            //    }

            if (batchChk.Checked)
            {
                try
                {
                    //Get all .texture files
                    var allFiles = Directory.GetFiles(texturePathTxt.Text, "*.texture", SearchOption.AllDirectories)
                        .ToList();

                    var saveLocation = "";
                    if (saveToChk.Checked)
                    {
                        if (DialogResult.OK == saveDDS.ShowDialog())
                            saveLocation = saveDDS.SelectedPath;
                        else return;
                        ddsPathTxt.Text = saveLocation;
                    }
                        

                    //Iterate all files and convert them to .dds
                    foreach (var file in allFiles)
                    {
                        var param = $"\"{file}\" {textureFormat} {offset} {texSize} {texSize}".Trim();
                        System.Diagnostics.Process.Start("RawtexCMD.exe", param);

                        if (saveToChk.Checked)
                        {
                            try
                            {
                                var ddsLocation = Path.ChangeExtension(file, "dds");
                                var ddsName = Path.GetFileName(ddsLocation);
                                string saveTo = Path.Combine(saveLocation, ddsName);
                                if (File.Exists(saveTo))
                                    if (DialogResult.OK != MessageBox.Show(
                                            $"File {ddsName} already in converted, a possible duplicate\nOverwrite file?",
                                            "Error", MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Error))
                                        continue;
                                File.Move(ddsLocation, saveTo, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Could not process files in batch mode!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                var param = $"\"{texturePathTxt.Text}\" {textureFormat} {offset} {texSize} {texSize}".Trim();
                System.Diagnostics.Process.Start("RawtexCMD.exe", param);
            }



            if (saveToChk.Checked && !batchChk.Checked)
            {
                try
                {
                    var ddsLocation = Path.ChangeExtension(texturePathTxt.Text, "dds");
                    var ddsName = Path.GetFileName(ddsLocation);
                    if (DialogResult.OK == saveDDS.ShowDialog())
                    {
                        string saveTo = Path.Combine(saveDDS.SelectedPath, ddsName);
                        File.Move(ddsLocation, saveTo, true);
                        ddsPathTxt.Text = batchChk.Checked ? ddsLocation : saveTo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            statusLbl.Text = "\u2714";
            statusLbl.ForeColor = Color.Green;
        }

        private void texturePathTxt_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                ((TextBox)sender).Text = files[0];
            }
        }

        private void selectDDSBtn_Click(object sender, EventArgs e)
        {
            var dialogRes = batchChk.Checked ? batchDDS.ShowDialog() : openDDS.ShowDialog();
            if (DialogResult.OK == dialogRes)
            {
                ddsPathTxt.Text = batchChk.Checked ? batchDDS.SelectedPath : openDDS.FileName;
            }
        }

        private void convertDDSBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(texturePathTxt.Text) || string.IsNullOrEmpty(ddsPathTxt.Text))
            {
                MessageBox.Show("Path is empty", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!backupChk.Checked && backupChk.Checked)
                if (DialogResult.Cancel == MessageBox.Show("Converted .dds files will be deleted!", "Warning!",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning))
                    return;

            if (batchChk.Checked)
            {
                //Check if directory
                if (!File.GetAttributes(texturePathTxt.Text).HasFlag(FileAttributes.Directory) || !File.GetAttributes(ddsPathTxt.Text).HasFlag(FileAttributes.Directory))
                {
                    MessageBox.Show( "Path is not a directory!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var allFiles = Directory.GetFiles(texturePathTxt.Text, "*.texture", SearchOption.AllDirectories)
                    .ToList();

                foreach (var file in allFiles)
                {
                    //Get matching texture file 
                    var requiredFile = Path.ChangeExtension(file, ".dds");
                    var matchingDDSFile = saveToChk.Checked ? Path.Combine(ddsPathTxt.Text, Path.GetFileName(requiredFile)) : requiredFile;
                    if (!File.Exists(matchingDDSFile))
                    {
                        MessageBox.Show($"Required {Path.GetFileName(matchingDDSFile)} file does not exist\nTry converting first", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    var texBytes = File.ReadAllBytes(file);
                    var ddsBytes = File.ReadAllBytes(matchingDDSFile);

                    //Retry batch label
                    retry_batch:
                    try
                    {
                        MakeTexture(ddsBytes, texBytes, file);

                        if (!backupChk.Checked)
                            File.Delete(matchingDDSFile);
                    }
                    catch (Exception ex)
                    {
                        if (DialogResult.Retry == MessageBox.Show(
                                $"{ex.Message}",
                                "Error",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                            goto retry_batch;
                        else goto stop;
                    }
                }
                MessageBox.Show("Successfully created .texture files!", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                stop: ;

            }

            else
            {
                if (!File.Exists(ddsPathTxt.Text) || File.GetAttributes(ddsPathTxt.Text).HasFlag(FileAttributes.Directory) || File.GetAttributes(texturePathTxt.Text).HasFlag(FileAttributes.Directory))
                {
                    MessageBox.Show( ".dds file does not exist!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                    

                retry:
                var p = ddsPathTxt.Text;
                var t = texturePathTxt.Text;
                var ddsBytes = File.ReadAllBytes(p);
                var texBytes = File.ReadAllBytes(t);
                try
                {
                    MakeTexture(ddsBytes, texBytes, texturePathTxt.Text);
                    MessageBox.Show("Successfully created .texture file!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    if (DialogResult.Retry == MessageBox.Show( ex.Message, "Error", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Error))
                        goto retry;
                }
            }
        }

        private void MakeTexture(byte[] dds, byte[] tex, string finalName)
        {
            //skip 0x94 bytes from start of dds
            var ddsBytes = dds.Skip(Convert.ToByte(0x94)).ToArray();

            //Get 0x80 original bytes
            var headerBytes = hasHeader ? tex.SkipLast(0x80).ToArray() : Array.Empty<byte>();

            var combine = headerBytes.Concat(ddsBytes).ToArray();

            //Cut remaining bytes to match original
            var result = combine.SkipLast(combine.Length - tex.Length).ToArray();
            File.WriteAllBytes(finalName, result);
        }

        private void texturePathTxt_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void batchChk_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(batchChk,"Allows you to select a folder and run the process recursively on all files and files in subdirectories");
        }

        private void backupChk_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(backupChk, "Prevents deletion of .dds files after conversion");
        }

        private void convertDDSBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(convertDDSBtn, "Convert .dds file(s) to .texture\nWarning: overwrites previous .texture files");
        }

        private void saveToChk_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(saveToChk, "Save .dds file(s) to specific folder\nIf Batch Mode is selected, matches files in selected .dds directory to .texture directory");
        }
    }
}