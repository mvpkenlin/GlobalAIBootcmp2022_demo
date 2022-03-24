using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Microsoft.Extensions.Configuration;
using System.Drawing.Imaging;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;

namespace AIDemo
{
    public partial class FormCustomVision : Form
    {
        private static FormCustomVision form;
        private static CustomVisionPredictionClient prediction_client;
        private static List<string> imagePaths = new List<string>();
        private static List<PictureBox> pictureBoxes = new List<PictureBox>();
        string prediction_endpoint ;
        string prediction_key ;
        Guid project_id, project_id2;
        string model_name, model_name2;

        public FormCustomVision()
        {
            InitializeComponent();
            form = this;
        }

        private void FormCustomVision_Load(object sender, EventArgs e)
        {
            try
            {
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                prediction_endpoint = configuration["PredictionEndpoint"];
                prediction_key = configuration["PredictionKey"];
                project_id = Guid.Parse(configuration["ProjectID"]);
                model_name = configuration["ModelName"];
                project_id2 = Guid.Parse(configuration["ProjectID2"]);
                model_name2 = configuration["ModelName2"];

                // Authenticate a client for the prediction API
                prediction_client = new CustomVisionPredictionClient(new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.ApiKeyServiceClientCredentials(prediction_key))
                {
                    Endpoint = prediction_endpoint
                };
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
            
        }

        private void DisplayError(string errorMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayInfo(string infoMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void msbtnLoadImages_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            msPanelResult.Controls.Clear();
            pictureBoxes.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                List<string> allfiles = Directory.GetFiles(folderPath).ToList();
                int filesCount = allfiles.Count;
                int intPanelWidth = msPanelResult.Width;
                int currentIndex = 1;
                foreach (string file in allfiles)
                {
                    PictureBox thisPictureBox = new PictureBox
                    {
                        Width = msPanelResult.Width / 3,
                        Height = msPanelResult.Height / 3,
                        Top = ((currentIndex-1) / 3) * (msPanelResult.Height / 3),
                        Left = ((currentIndex-1) %  3) * (msPanelResult.Width / 3),
                        //Image = Image.FromFile(file),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = file
                    } ;
                    msPanelResult.Controls.Add(thisPictureBox);
                    pictureBoxes.Add(thisPictureBox);
                    currentIndex = currentIndex+1;
                }
            }
        }

        private void msbtnTestFruit_Click(object sender, EventArgs e)
        {
            CallPredictService(project_id, model_name, "fruit-classifier");
        }

        private void msbtnTestLandmark_Click(object sender, EventArgs e)
        {
            CallPredictService(project_id2, model_name2, "landmark-classifier");
        }

        private void CallPredictService(Guid project_id, string model_name, string newFilename)
        {
            try
            {
                int currentIndex = 0;
                foreach (PictureBox picBox in pictureBoxes)
                {
                    MemoryStream image_data = new MemoryStream(File.ReadAllBytes(picBox.ImageLocation));
                    var result = prediction_client.ClassifyImage(project_id, model_name, image_data);

                    // Loop over each label prediction and print any with probability > 50%
                    foreach (var prediction in result.Predictions)
                    {
                        if (prediction.Probability > 0.5)
                        {
                            Console.WriteLine($"{prediction.TagName} ({prediction.Probability:P1})");
                            DrawAnnotate($"{prediction.TagName} ({prediction.Probability:P1})", picBox, newFilename);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void DrawAnnotate(string predictionResult, PictureBox pictureBox, string newFileName)
        {
            try
            {
                string imageFile = pictureBox.ImageLocation;
                // Prepare image for drawing
                Image image = Image.FromFile(imageFile);
                Graphics graphics = Graphics.FromImage(image);
                Pen pen = new Pen(Color.DeepSkyBlue, (image.Size.Width/20));
                Font font = new("Times New Roman", (image.Size.Height /20), FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Red);

                Rectangle rect = new Rectangle(1, 1, image.Size.Width, image.Size.Height);
                graphics.DrawRectangle(pen, rect);
                
                // Draw and annotate each face
                graphics.DrawString(predictionResult, font, brush, (image.Size.Width / 20), (image.Size.Width / 20));
                pictureBox.ImageLocation = SaveImage1(image, imageFile, newFileName);              

            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private string SaveImage1(Image image, string imageFile, string newFilename)
        {
            // get the output filename
            string folderPath = Path.Combine(Path.GetDirectoryName(imageFile) ?? ".", "demoOutput");
            string filename = Path.GetFileNameWithoutExtension(imageFile);
            string fileExt = Path.GetExtension(imageFile);
            System.IO.Directory.CreateDirectory(folderPath);
            var dtNow = DateTime.Now.ToString("yyyyMMdd-hhmmss");
            //String output_file = $"{folderPath}\\{filename}.{newFilename}.{dtNow}.{fileExt}";

            string fdFileName = $"{filename}.{newFilename}.{dtNow}.{fileExt}";
            string savingfdFilePath = Path.Combine(folderPath, fdFileName);

            // Save annotated image
            image.Save(savingfdFilePath);
            return savingfdFilePath;
        }

        
    }
}
