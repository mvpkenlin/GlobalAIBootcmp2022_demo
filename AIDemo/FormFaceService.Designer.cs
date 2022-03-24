namespace AIDemo
{
    partial class FormFaceService
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.msbtnFaceVerify = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.msbtnCallAPI = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.mstxtImagePath2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.msbtnOpenFile2 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.mstxtImagePath1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.msbtnOpenFile1 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroSetPanel1.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.msbtnFaceVerify);
            this.metroSetPanel1.Controls.Add(this.msbtnCallAPI);
            this.metroSetPanel1.Controls.Add(this.mstxtImagePath2);
            this.metroSetPanel1.Controls.Add(this.msbtnOpenFile2);
            this.metroSetPanel1.Controls.Add(this.mstxtImagePath1);
            this.metroSetPanel1.Controls.Add(this.msbtnOpenFile1);
            this.metroSetPanel1.Controls.Add(this.btnClose);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1369, 112);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 4;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // msbtnFaceVerify
            // 
            this.msbtnFaceVerify.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msbtnFaceVerify.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnFaceVerify.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnFaceVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnFaceVerify.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnFaceVerify.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnFaceVerify.HoverTextColor = System.Drawing.Color.White;
            this.msbtnFaceVerify.IsDerivedStyle = true;
            this.msbtnFaceVerify.Location = new System.Drawing.Point(333, 74);
            this.msbtnFaceVerify.Name = "msbtnFaceVerify";
            this.msbtnFaceVerify.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msbtnFaceVerify.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.msbtnFaceVerify.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnFaceVerify.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnFaceVerify.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnFaceVerify.PressTextColor = System.Drawing.Color.White;
            this.msbtnFaceVerify.Size = new System.Drawing.Size(164, 29);
            this.msbtnFaceVerify.Style = MetroSet_UI.Enums.Style.Dark;
            this.msbtnFaceVerify.StyleManager = null;
            this.msbtnFaceVerify.TabIndex = 8;
            this.msbtnFaceVerify.Text = "Face Compare";
            this.msbtnFaceVerify.ThemeAuthor = "Narwin";
            this.msbtnFaceVerify.ThemeName = "MetroDark";
            this.msbtnFaceVerify.Click += new System.EventHandler(this.msbtnFaceVerify_Click);
            // 
            // msbtnCallAPI
            // 
            this.msbtnCallAPI.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msbtnCallAPI.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnCallAPI.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnCallAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnCallAPI.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnCallAPI.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnCallAPI.HoverTextColor = System.Drawing.Color.White;
            this.msbtnCallAPI.IsDerivedStyle = true;
            this.msbtnCallAPI.Location = new System.Drawing.Point(145, 74);
            this.msbtnCallAPI.Name = "msbtnCallAPI";
            this.msbtnCallAPI.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msbtnCallAPI.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.msbtnCallAPI.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnCallAPI.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnCallAPI.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnCallAPI.PressTextColor = System.Drawing.Color.White;
            this.msbtnCallAPI.Size = new System.Drawing.Size(164, 29);
            this.msbtnCallAPI.Style = MetroSet_UI.Enums.Style.Dark;
            this.msbtnCallAPI.StyleManager = null;
            this.msbtnCallAPI.TabIndex = 7;
            this.msbtnCallAPI.Text = "Face API";
            this.msbtnCallAPI.ThemeAuthor = "Narwin";
            this.msbtnCallAPI.ThemeName = "MetroDark";
            this.msbtnCallAPI.Click += new System.EventHandler(this.msbtnCallAPI_Click);
            // 
            // mstxtImagePath2
            // 
            this.mstxtImagePath2.AutoCompleteCustomSource = null;
            this.mstxtImagePath2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mstxtImagePath2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mstxtImagePath2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mstxtImagePath2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mstxtImagePath2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mstxtImagePath2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.mstxtImagePath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mstxtImagePath2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mstxtImagePath2.Image = null;
            this.mstxtImagePath2.IsDerivedStyle = true;
            this.mstxtImagePath2.Lines = null;
            this.mstxtImagePath2.Location = new System.Drawing.Point(145, 39);
            this.mstxtImagePath2.MaxLength = 32767;
            this.mstxtImagePath2.Multiline = false;
            this.mstxtImagePath2.Name = "mstxtImagePath2";
            this.mstxtImagePath2.ReadOnly = false;
            this.mstxtImagePath2.Size = new System.Drawing.Size(731, 29);
            this.mstxtImagePath2.Style = MetroSet_UI.Enums.Style.Light;
            this.mstxtImagePath2.StyleManager = null;
            this.mstxtImagePath2.TabIndex = 5;
            this.mstxtImagePath2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mstxtImagePath2.ThemeAuthor = "Narwin";
            this.mstxtImagePath2.ThemeName = "MetroLite";
            this.mstxtImagePath2.UseSystemPasswordChar = false;
            this.mstxtImagePath2.WatermarkText = "";
            // 
            // msbtnOpenFile2
            // 
            this.msbtnOpenFile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msbtnOpenFile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnOpenFile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile2.HoverTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile2.IsDerivedStyle = true;
            this.msbtnOpenFile2.Location = new System.Drawing.Point(45, 39);
            this.msbtnOpenFile2.Name = "msbtnOpenFile2";
            this.msbtnOpenFile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msbtnOpenFile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.msbtnOpenFile2.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnOpenFile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile2.PressTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile2.Size = new System.Drawing.Size(94, 29);
            this.msbtnOpenFile2.Style = MetroSet_UI.Enums.Style.Dark;
            this.msbtnOpenFile2.StyleManager = null;
            this.msbtnOpenFile2.TabIndex = 4;
            this.msbtnOpenFile2.Text = "Image 2";
            this.msbtnOpenFile2.ThemeAuthor = "Narwin";
            this.msbtnOpenFile2.ThemeName = "MetroDark";
            this.msbtnOpenFile2.Click += new System.EventHandler(this.msbtnOpenFile2_Click);
            // 
            // mstxtImagePath1
            // 
            this.mstxtImagePath1.AutoCompleteCustomSource = null;
            this.mstxtImagePath1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mstxtImagePath1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mstxtImagePath1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mstxtImagePath1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mstxtImagePath1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mstxtImagePath1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.mstxtImagePath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mstxtImagePath1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mstxtImagePath1.Image = null;
            this.mstxtImagePath1.IsDerivedStyle = true;
            this.mstxtImagePath1.Lines = null;
            this.mstxtImagePath1.Location = new System.Drawing.Point(145, 4);
            this.mstxtImagePath1.MaxLength = 32767;
            this.mstxtImagePath1.Multiline = false;
            this.mstxtImagePath1.Name = "mstxtImagePath1";
            this.mstxtImagePath1.ReadOnly = false;
            this.mstxtImagePath1.Size = new System.Drawing.Size(731, 29);
            this.mstxtImagePath1.Style = MetroSet_UI.Enums.Style.Light;
            this.mstxtImagePath1.StyleManager = null;
            this.mstxtImagePath1.TabIndex = 3;
            this.mstxtImagePath1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mstxtImagePath1.ThemeAuthor = "Narwin";
            this.mstxtImagePath1.ThemeName = "MetroLite";
            this.mstxtImagePath1.UseSystemPasswordChar = false;
            this.mstxtImagePath1.WatermarkText = "";
            // 
            // msbtnOpenFile1
            // 
            this.msbtnOpenFile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msbtnOpenFile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msbtnOpenFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnOpenFile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msbtnOpenFile1.HoverTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile1.IsDerivedStyle = true;
            this.msbtnOpenFile1.Location = new System.Drawing.Point(45, 4);
            this.msbtnOpenFile1.Name = "msbtnOpenFile1";
            this.msbtnOpenFile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msbtnOpenFile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.msbtnOpenFile1.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnOpenFile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.msbtnOpenFile1.PressTextColor = System.Drawing.Color.White;
            this.msbtnOpenFile1.Size = new System.Drawing.Size(94, 29);
            this.msbtnOpenFile1.Style = MetroSet_UI.Enums.Style.Dark;
            this.msbtnOpenFile1.StyleManager = null;
            this.msbtnOpenFile1.TabIndex = 2;
            this.msbtnOpenFile1.Text = "Image 1";
            this.msbtnOpenFile1.ThemeAuthor = "Narwin";
            this.msbtnOpenFile1.ThemeName = "MetroDark";
            this.msbtnOpenFile1.Click += new System.EventHandler(this.msbtnOpenFile1_Click);
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.splitContainer1);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 112);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(1369, 877);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 5;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroDark";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1369, 877);
            this.splitContainer1.SplitterDistance = 666;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtResult.Location = new System.Drawing.Point(0, 406);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(666, 471);
            this.txtResult.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(693, 877);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormFaceService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 989);
            this.Controls.Add(this.metroSetPanel2);
            this.Controls.Add(this.metroSetPanel1);
            this.Name = "FormFaceService";
            this.Text = "Face Detection";
            this.Load += new System.EventHandler(this.FormFaceDetection_Load);
            this.metroSetPanel1.ResumeLayout(false);
            this.metroSetPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnClose;
        private OpenFileDialog openFileDialog1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnOpenFile1;
        private MetroSet_UI.Controls.MetroSetTextBox mstxtImagePath1;
        private MetroSet_UI.Controls.MetroSetTextBox mstxtImagePath2;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnOpenFile2;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnCallAPI;
        private TextBox txtResult;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnFaceVerify;
    }
}