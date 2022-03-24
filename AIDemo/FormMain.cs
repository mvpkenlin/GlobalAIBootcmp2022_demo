using MetroSet_UI.Forms;
using System.Diagnostics;

namespace AIDemo
{
    public partial class FormMain : MetroSetForm
    {
        public FormMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void CustomizeDesign()
        {
            panelFaceServiceSubmenu.Visible = false;
            panelCustomVisionSubmenu.Visible = false;
            panelAzureVideoAnalyzerSubmenu.Visible = false;
            panelLUISSubmenu.Visible = false;
            panelSpeechEnabledSubmenu.Visible = false;
        }

        #region Show Hide Menu
        private void HideSubmenu()
        {
            if (panelFaceServiceSubmenu.Visible == true)
                panelFaceServiceSubmenu.Visible = false;
            if (panelCustomVisionSubmenu.Visible == true)
                panelCustomVisionSubmenu.Visible = false;
            if (panelAzureVideoAnalyzerSubmenu.Visible == true)
                panelAzureVideoAnalyzerSubmenu.Visible = false;
            if (panelLUISSubmenu.Visible == true)
                panelLUISSubmenu.Visible = false;
            if (panelSpeechEnabledSubmenu.Visible == true)
                panelSpeechEnabledSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnFaceService_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelFaceServiceSubmenu);
        }
        private void btnImageAnalyze_Click(object sender, EventArgs e)
        {
            // do the work
            OpenChildForm(new FormImageAnalyze());
            HideSubmenu();
        }

        private void btnFaceServiceSDK_Click(object sender, EventArgs e)
        {
            // do the work
            OpenChildForm(new FormFaceService());
            HideSubmenu();
        }

        private void btnCustomVision_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelCustomVisionSubmenu);
        }

        private void btnAzureVideoAnalyzer_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelAzureVideoAnalyzerSubmenu);
        }

        private void btnLUIS_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelLUISSubmenu);  
        }

        private void btnSpeechEnabled_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSpeechEnabledSubmenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            // do the work
            OpenChildForm(new FormVideoAnalyzer());
            HideSubmenu();
        }

        private void btnOpenCV_Click(object sender, EventArgs e)
        {
            // do the work
            OpenChildForm(new FormCustomVision());
            HideSubmenu();
        }

        private void btnOpenLUIS_Click(object sender, EventArgs e)
        {
            // do the work
            OpenChildForm(new FormLUIS());
            HideSubmenu();
        }
    }
}