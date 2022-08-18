namespace SpiderManTextureTool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.texturePathTxt = new System.Windows.Forms.TextBox();
            this.selectTextureBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textureSizeCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textureFormatCmb = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.convertToDDSBtn = new System.Windows.Forms.Button();
            this.saveToChk = new System.Windows.Forms.CheckBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.openTexture = new System.Windows.Forms.OpenFileDialog();
            this.saveTexture = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ddsPathTxt = new System.Windows.Forms.TextBox();
            this.selectDDSBtn = new System.Windows.Forms.Button();
            this.convertDDSBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveDDS = new System.Windows.Forms.FolderBrowserDialog();
            this.openDDS = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(945, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original .texture file";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.texturePathTxt);
            this.flowLayoutPanel1.Controls.Add(this.selectTextureBtn);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 67);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // texturePathTxt
            // 
            this.texturePathTxt.AllowDrop = true;
            this.texturePathTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.texturePathTxt.Location = new System.Drawing.Point(3, 5);
            this.texturePathTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texturePathTxt.Name = "texturePathTxt";
            this.texturePathTxt.Size = new System.Drawing.Size(803, 26);
            this.texturePathTxt.TabIndex = 0;
            this.texturePathTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePathTxt_DragDrop);
            // 
            // selectTextureBtn
            // 
            this.selectTextureBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectTextureBtn.Location = new System.Drawing.Point(812, 4);
            this.selectTextureBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectTextureBtn.Name = "selectTextureBtn";
            this.selectTextureBtn.Size = new System.Drawing.Size(86, 29);
            this.selectTextureBtn.TabIndex = 1;
            this.selectTextureBtn.Text = "Select";
            this.selectTextureBtn.UseVisualStyleBackColor = true;
            this.selectTextureBtn.Click += new System.EventHandler(this.selectTextureBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original file should not be changed until .dds is edited and converted";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(945, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert to .dds";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(939, 126);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textureSizeCmb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textureFormatCmb, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 70);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texture Size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textureSizeCmb
            // 
            this.textureSizeCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textureSizeCmb.FormattingEnabled = true;
            this.textureSizeCmb.Items.AddRange(new object[] {
            "Auto",
            "512",
            "1024",
            "2048"});
            this.textureSizeCmb.Location = new System.Drawing.Point(92, 4);
            this.textureSizeCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textureSizeCmb.Name = "textureSizeCmb";
            this.textureSizeCmb.Size = new System.Drawing.Size(138, 27);
            this.textureSizeCmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textureFormatCmb
            // 
            this.textureFormatCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textureFormatCmb.FormattingEnabled = true;
            this.textureFormatCmb.Items.AddRange(new object[] {
            "BC1",
            "BC2",
            "BC3",
            "BC4",
            "BC5",
            "BC6",
            "BC7",
            "BC5U",
            "BC5S",
            "DXT1",
            "DXT3",
            "DXT5",
            "DX10"});
            this.textureFormatCmb.Location = new System.Drawing.Point(92, 39);
            this.textureFormatCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textureFormatCmb.Name = "textureFormatCmb";
            this.textureFormatCmb.Size = new System.Drawing.Size(138, 27);
            this.textureFormatCmb.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.convertToDDSBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveToChk, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusLbl, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 37);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // convertToDDSBtn
            // 
            this.convertToDDSBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.convertToDDSBtn.Location = new System.Drawing.Point(3, 4);
            this.convertToDDSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.convertToDDSBtn.Name = "convertToDDSBtn";
            this.convertToDDSBtn.Size = new System.Drawing.Size(86, 29);
            this.convertToDDSBtn.TabIndex = 1;
            this.convertToDDSBtn.Text = "Convert";
            this.convertToDDSBtn.UseVisualStyleBackColor = true;
            this.convertToDDSBtn.Click += new System.EventHandler(this.convertToDDSBtn_Click);
            // 
            // saveToChk
            // 
            this.saveToChk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveToChk.AutoSize = true;
            this.saveToChk.Location = new System.Drawing.Point(95, 7);
            this.saveToChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveToChk.Name = "saveToChk";
            this.saveToChk.Size = new System.Drawing.Size(121, 23);
            this.saveToChk.TabIndex = 4;
            this.saveToChk.Text = "Non Local Save";
            this.saveToChk.UseVisualStyleBackColor = true;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLbl.Location = new System.Drawing.Point(222, 9);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(50, 19);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "label5";
            // 
            // openTexture
            // 
            this.openTexture.Filter = "Texture FIle | *.texture";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 251);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(945, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convert .dds to .texture";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.ddsPathTxt);
            this.flowLayoutPanel3.Controls.Add(this.selectDDSBtn);
            this.flowLayoutPanel3.Controls.Add(this.convertDDSBtn);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(939, 59);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // ddsPathTxt
            // 
            this.ddsPathTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ddsPathTxt.Location = new System.Drawing.Point(3, 5);
            this.ddsPathTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddsPathTxt.Name = "ddsPathTxt";
            this.ddsPathTxt.Size = new System.Drawing.Size(706, 26);
            this.ddsPathTxt.TabIndex = 0;
            // 
            // selectDDSBtn
            // 
            this.selectDDSBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectDDSBtn.Location = new System.Drawing.Point(715, 4);
            this.selectDDSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectDDSBtn.Name = "selectDDSBtn";
            this.selectDDSBtn.Size = new System.Drawing.Size(86, 29);
            this.selectDDSBtn.TabIndex = 1;
            this.selectDDSBtn.Text = "Select";
            this.selectDDSBtn.UseVisualStyleBackColor = true;
            this.selectDDSBtn.Click += new System.EventHandler(this.selectDDSBtn_Click);
            // 
            // convertDDSBtn
            // 
            this.convertDDSBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.convertDDSBtn.Location = new System.Drawing.Point(807, 4);
            this.convertDDSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.convertDDSBtn.Name = "convertDDSBtn";
            this.convertDDSBtn.Size = new System.Drawing.Size(86, 29);
            this.convertDDSBtn.TabIndex = 1;
            this.convertDDSBtn.Text = "Convert";
            this.convertDDSBtn.UseVisualStyleBackColor = true;
            this.convertDDSBtn.Click += new System.EventHandler(this.convertDDSBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Original .texture file should be present in the \'Original\' section before convers" +
    "ion";
            // 
            // openDDS
            // 
            this.openDDS.Filter = "DDS FIle | *.dds";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "Marvel\'s Spider-Man PC Texture tool by Leon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox texturePathTxt;
        private Button selectTextureBtn;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox textureSizeCmb;
        private Label label2;
        private ComboBox textureFormatCmb;
        private Button convertToDDSBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private OpenFileDialog openTexture;
        private SaveFileDialog saveTexture;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox ddsPathTxt;
        private Button selectDDSBtn;
        private Button convertDDSBtn;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox saveToChk;
        private FolderBrowserDialog saveDDS;
        private OpenFileDialog openDDS;
        private Label statusLbl;
    }
}