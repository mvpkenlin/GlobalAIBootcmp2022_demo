namespace AIDemo
{
    partial class FormImageAnalyze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboxZoomIn = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.mstxtFilePath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.msbtnOpenFile = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetPanel3 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroSetPanel2.SuspendLayout();
            this.metroSetPanel3.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(7, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1361, 905);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Analyze";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtResult.Location = new System.Drawing.Point(803, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(555, 899);
            this.txtResult.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 899);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResult2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1361, 905);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Face Detect";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResult2
            // 
            this.txtResult2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtResult2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult2.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtResult2.Location = new System.Drawing.Point(803, 3);
            this.txtResult2.Multiline = true;
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult2.Size = new System.Drawing.Size(555, 899);
            this.txtResult2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 899);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResult3);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.cboxZoomIn);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1361, 905);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thumbnail";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResult3
            // 
            this.txtResult3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtResult3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult3.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtResult3.Location = new System.Drawing.Point(800, 27);
            this.txtResult3.Multiline = true;
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult3.Size = new System.Drawing.Size(561, 878);
            this.txtResult3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 878);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // cboxZoomIn
            // 
            this.cboxZoomIn.AutoSize = true;
            this.cboxZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cboxZoomIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxZoomIn.Location = new System.Drawing.Point(0, 0);
            this.cboxZoomIn.Name = "cboxZoomIn";
            this.cboxZoomIn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cboxZoomIn.Size = new System.Drawing.Size(1361, 27);
            this.cboxZoomIn.TabIndex = 8;
            this.cboxZoomIn.Text = "Zoom in";
            this.cboxZoomIn.UseVisualStyleBackColor = false;
            this.cboxZoomIn.CheckedChanged += new System.EventHandler(this.cboxZoomIn_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel2.BorderThickness = 0;
            this.metroSetPanel2.Controls.Add(this.mstxtFilePath);
            this.metroSetPanel2.Controls.Add(this.btnClose);
            this.metroSetPanel2.Controls.Add(this.msbtnOpenFile);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(1369, 38);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 0;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroDark";
            // 
            // mstxtFilePath
            // 
            this.mstxtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mstxtFilePath.AutoCompleteCustomSource = null;
            this.mstxtFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mstxtFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mstxtFilePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mstxtFilePath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mstxtFilePath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mstxtFilePath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mstxtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mstxtFilePath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mstxtFilePath.Image = null;
            this.mstxtFilePath.IsDerivedStyle = true;
            this.mstxtFilePath.Lines = null;
            this.mstxtFilePath.Location = new System.Drawing.Point(140, 8);
            this.mstxtFilePath.MaxLength = 32767;
            this.mstxtFilePath.Multiline = false;
            this.mstxtFilePath.Name = "mstxtFilePath";
            this.mstxtFilePath.ReadOnly = false;
            this.mstxtFilePath.Size = new System.Drawing.Size(1217, 27);
            this.mstxtFilePath.Style = MetroSet_UI.Enums.Style.Dark;
            this.mstxtFilePath.StyleManager = null;
            this.mstxtFilePath.TabIndex = 6;
            this.mstxtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mstxtFilePath.ThemeAuthor = "Narwin";
            this.mstxtFilePath.ThemeName = "MetroDark";
            this.mstxtFilePath.UseSystemPasswordChar = false;
            this.mstxtFilePath.WatermarkText = "";
            // 
            // msbtnOpenFile
            // 
            this.msbtnOpenFile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msbtnOpenFile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnOpenFile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile.HoverTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile.IsDerivedStyle = true;
            this.msbtnOpenFile.Location = new System.Drawing.Point(43, 6);
            this.msbtnOpenFile.Name = "msbtnOpenFile";
            this.msbtnOpenFile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msbtnOpenFile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.msbtnOpenFile.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnOpenFile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile.PressTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile.Size = new System.Drawing.Size(94, 29);
            this.msbtnOpenFile.Style = MetroSet_UI.Enums.Style.Dark;
            this.msbtnOpenFile.StyleManager = null;
            this.msbtnOpenFile.TabIndex = 5;
            this.msbtnOpenFile.Text = "Browse";
            this.msbtnOpenFile.ThemeAuthor = "Narwin";
            this.msbtnOpenFile.ThemeName = "MetroDark";
            this.msbtnOpenFile.Click += new System.EventHandler(this.msbtnOpenFile_Click);
            // 
            // metroSetPanel3
            // 
            this.metroSetPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel3.BorderThickness = 0;
            this.metroSetPanel3.Controls.Add(this.metroSetTabControl1);
            this.metroSetPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel3.IsDerivedStyle = true;
            this.metroSetPanel3.Location = new System.Drawing.Point(0, 38);
            this.metroSetPanel3.Name = "metroSetPanel3";
            this.metroSetPanel3.Size = new System.Drawing.Size(1369, 951);
            this.metroSetPanel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel3.StyleManager = null;
            this.metroSetPanel3.TabIndex = 0;
            this.metroSetPanel3.ThemeAuthor = "Narwin";
            this.metroSetPanel3.ThemeName = "MetroDark";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.tabPage1);
            this.metroSetTabControl1.Controls.Add(this.tabPage3);
            this.metroSetTabControl1.Controls.Add(this.tabPage2);
            this.metroSetTabControl1.Controls.Add(this.tabPage4);
            this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1369, 951);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1361, 905);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            // 
            // FormImageAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1369, 989);
            this.Controls.Add(this.metroSetPanel3);
            this.Controls.Add(this.metroSetPanel2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "FormImageAnalyze";
            this.Text = "Image Analyze";
            this.Load += new System.EventHandler(this.FormFaceDetection_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel3.ResumeLayout(false);
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnClose;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtResult;
        private PictureBox pictureBox2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtResult2;
        private TabPage tabPage3;
        private TextBox txtResult3;
        private PictureBox pictureBox3;
        private CheckBox cboxZoomIn;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnOpenFile;
        private MetroSet_UI.Controls.MetroSetTextBox mstxtFilePath;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel3;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private TabPage tabPage4;
    }
}