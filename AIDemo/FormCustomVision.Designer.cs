namespace AIDemo
{
    partial class FormCustomVision
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
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.msbtnLoadImages = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.msbtnTestLandmark = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.msbtnTestFruit = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msPanelResult = new MetroSet_UI.Controls.MetroSetPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.msbtnLoadImages);
            this.metroSetPanel1.Controls.Add(this.msbtnTestLandmark);
            this.metroSetPanel1.Controls.Add(this.msbtnTestFruit);
            this.metroSetPanel1.Controls.Add(this.label4);
            this.metroSetPanel1.Controls.Add(this.label3);
            this.metroSetPanel1.Controls.Add(this.label2);
            this.metroSetPanel1.Controls.Add(this.textBox2);
            this.metroSetPanel1.Controls.Add(this.label1);
            this.metroSetPanel1.Controls.Add(this.textBox1);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1014, 206);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // msbtnLoadImages
            // 
            this.msbtnLoadImages.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnLoadImages.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msbtnLoadImages.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.msbtnLoadImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnLoadImages.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnLoadImages.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnLoadImages.HoverTextColor = System.Drawing.Color.White;
            this.msbtnLoadImages.IsDerivedStyle = true;
            this.msbtnLoadImages.Location = new System.Drawing.Point(265, 139);
            this.msbtnLoadImages.Name = "msbtnLoadImages";
            this.msbtnLoadImages.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnLoadImages.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msbtnLoadImages.NormalTextColor = System.Drawing.Color.Black;
            this.msbtnLoadImages.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnLoadImages.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnLoadImages.PressTextColor = System.Drawing.Color.White;
            this.msbtnLoadImages.Size = new System.Drawing.Size(173, 50);
            this.msbtnLoadImages.Style = MetroSet_UI.Enums.Style.Light;
            this.msbtnLoadImages.StyleManager = null;
            this.msbtnLoadImages.TabIndex = 8;
            this.msbtnLoadImages.Text = "Load Images";
            this.msbtnLoadImages.ThemeAuthor = "Narwin";
            this.msbtnLoadImages.ThemeName = "MetroLite";
            this.msbtnLoadImages.Click += new System.EventHandler(this.msbtnLoadImages_Click);
            // 
            // msbtnTestLandmark
            // 
            this.msbtnTestLandmark.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnTestLandmark.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msbtnTestLandmark.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.msbtnTestLandmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnTestLandmark.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnTestLandmark.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnTestLandmark.HoverTextColor = System.Drawing.Color.White;
            this.msbtnTestLandmark.IsDerivedStyle = true;
            this.msbtnTestLandmark.Location = new System.Drawing.Point(651, 139);
            this.msbtnTestLandmark.Name = "msbtnTestLandmark";
            this.msbtnTestLandmark.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnTestLandmark.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msbtnTestLandmark.NormalTextColor = System.Drawing.Color.Black;
            this.msbtnTestLandmark.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnTestLandmark.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnTestLandmark.PressTextColor = System.Drawing.Color.White;
            this.msbtnTestLandmark.Size = new System.Drawing.Size(173, 50);
            this.msbtnTestLandmark.Style = MetroSet_UI.Enums.Style.Light;
            this.msbtnTestLandmark.StyleManager = null;
            this.msbtnTestLandmark.TabIndex = 7;
            this.msbtnTestLandmark.Text = "Test Landmark";
            this.msbtnTestLandmark.ThemeAuthor = "Narwin";
            this.msbtnTestLandmark.ThemeName = "MetroLite";
            this.msbtnTestLandmark.Click += new System.EventHandler(this.msbtnTestLandmark_Click);
            // 
            // msbtnTestFruit
            // 
            this.msbtnTestFruit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnTestFruit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msbtnTestFruit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.msbtnTestFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnTestFruit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnTestFruit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnTestFruit.HoverTextColor = System.Drawing.Color.White;
            this.msbtnTestFruit.IsDerivedStyle = true;
            this.msbtnTestFruit.Location = new System.Drawing.Point(457, 139);
            this.msbtnTestFruit.Name = "msbtnTestFruit";
            this.msbtnTestFruit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnTestFruit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msbtnTestFruit.NormalTextColor = System.Drawing.Color.Black;
            this.msbtnTestFruit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnTestFruit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnTestFruit.PressTextColor = System.Drawing.Color.White;
            this.msbtnTestFruit.Size = new System.Drawing.Size(173, 50);
            this.msbtnTestFruit.Style = MetroSet_UI.Enums.Style.Light;
            this.msbtnTestFruit.StyleManager = null;
            this.msbtnTestFruit.TabIndex = 6;
            this.msbtnTestFruit.Text = "Test Fruit";
            this.msbtnTestFruit.ThemeAuthor = "Narwin";
            this.msbtnTestFruit.ThemeName = "MetroLite";
            this.msbtnTestFruit.Click += new System.EventHandler(this.msbtnTestFruit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "4) Click and Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "3) Search and save new images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "2) Run online test in Custom Vision";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "https://aka.ms/apple-image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1) Browse to";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "https://customvision.ai";
            // 
            // msPanelResult
            // 
            this.msPanelResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.msPanelResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.msPanelResult.BorderThickness = 1;
            this.msPanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msPanelResult.IsDerivedStyle = true;
            this.msPanelResult.Location = new System.Drawing.Point(0, 206);
            this.msPanelResult.Name = "msPanelResult";
            this.msPanelResult.Size = new System.Drawing.Size(1014, 521);
            this.msPanelResult.Style = MetroSet_UI.Enums.Style.Dark;
            this.msPanelResult.StyleManager = null;
            this.msPanelResult.TabIndex = 1;
            this.msPanelResult.ThemeAuthor = "Narwin";
            this.msPanelResult.ThemeName = "MetroDark";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.Startup;
            // 
            // FormCustomVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 727);
            this.Controls.Add(this.msPanelResult);
            this.Controls.Add(this.metroSetPanel1);
            this.Name = "FormCustomVision";
            this.Text = "FormCustomVision";
            this.Load += new System.EventHandler(this.FormCustomVision_Load);
            this.metroSetPanel1.ResumeLayout(false);
            this.metroSetPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnTestLandmark;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnTestFruit;
        private Label label4;
        private Label label3;
        private MetroSet_UI.Controls.MetroSetPanel msPanelResult;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnLoadImages;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}