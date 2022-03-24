namespace AIDemo
{
    partial class FormLUIS
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.msbtnAskTime = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.txtTimeAnswer = new System.Windows.Forms.TextBox();
            this.txtAskTime = new System.Windows.Forms.TextBox();
            this.metroSetPanel1.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.label1);
            this.metroSetPanel1.Controls.Add(this.textBox1);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1003, 155);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1) Browse to";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(774, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "https://www.luis.ai";
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.msbtnAskTime);
            this.metroSetPanel2.Controls.Add(this.txtTimeAnswer);
            this.metroSetPanel2.Controls.Add(this.txtAskTime);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 155);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(1003, 525);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 1;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroDark";
            // 
            // msbtnAskTime
            // 
            this.msbtnAskTime.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnAskTime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msbtnAskTime.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.msbtnAskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msbtnAskTime.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnAskTime.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msbtnAskTime.HoverTextColor = System.Drawing.Color.White;
            this.msbtnAskTime.IsDerivedStyle = true;
            this.msbtnAskTime.Location = new System.Drawing.Point(438, 6);
            this.msbtnAskTime.Name = "msbtnAskTime";
            this.msbtnAskTime.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msbtnAskTime.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msbtnAskTime.NormalTextColor = System.Drawing.Color.Black;
            this.msbtnAskTime.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnAskTime.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msbtnAskTime.PressTextColor = System.Drawing.Color.White;
            this.msbtnAskTime.Size = new System.Drawing.Size(94, 29);
            this.msbtnAskTime.Style = MetroSet_UI.Enums.Style.Light;
            this.msbtnAskTime.StyleManager = null;
            this.msbtnAskTime.TabIndex = 2;
            this.msbtnAskTime.Text = "Ask Time";
            this.msbtnAskTime.ThemeAuthor = "Narwin";
            this.msbtnAskTime.ThemeName = "MetroLite";
            this.msbtnAskTime.Click += new System.EventHandler(this.msbtnAskTime_Click);
            // 
            // txtTimeAnswer
            // 
            this.txtTimeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimeAnswer.Location = new System.Drawing.Point(14, 39);
            this.txtTimeAnswer.Multiline = true;
            this.txtTimeAnswer.Name = "txtTimeAnswer";
            this.txtTimeAnswer.Size = new System.Drawing.Size(518, 474);
            this.txtTimeAnswer.TabIndex = 1;
            // 
            // txtAskTime
            // 
            this.txtAskTime.Location = new System.Drawing.Point(14, 6);
            this.txtAskTime.Name = "txtAskTime";
            this.txtAskTime.Size = new System.Drawing.Size(418, 27);
            this.txtAskTime.TabIndex = 0;
            // 
            // FormLUIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 680);
            this.Controls.Add(this.metroSetPanel2);
            this.Controls.Add(this.metroSetPanel1);
            this.Name = "FormLUIS";
            this.Text = "FormLUIS";
            this.Load += new System.EventHandler(this.FormLUIS_Load);
            this.metroSetPanel1.ResumeLayout(false);
            this.metroSetPanel1.PerformLayout();
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private Label label1;
        private TextBox textBox1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetDefaultButton msbtnAskTime;
        private TextBox txtTimeAnswer;
        private TextBox txtAskTime;
    }
}