using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
// import namespaces
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;

namespace AIDemo
{
    public partial class FormImageAnalyze : Form
    {
        private static ComputerVisionClient cvClient;
        private static string cogSvcEndpoint;
        private static string cogSvcKey;
        private static FormImageAnalyze form = null;
        
        public FormImageAnalyze()
        {
            InitializeComponent();
            form = this;
        }

        public string FilePathText 
        { 
            get { return mstxtFilePath.Text; } 
            set { mstxtFilePath.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void FormFaceDetection_Load(object sender, EventArgs e)
        {
            try
            {
                // Get config settings from AppSettings
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                cogSvcEndpoint = configuration["CognitiveServicesEndpoint"];
                cogSvcKey = configuration["CognitiveServiceKey"];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                form.SetErrorMessage(ex.Message);
            }
        }

        //private async void btnOpenFile_Click(object sender, EventArgs e)
        //{
        //    form.ResetErrorMessage();
        //    form.ResetResultTextBox();
        //    OpenFile(txtFilePath, mstxtFilePath, openFileDialog1);
        //    await ProcessImage(txtFilePath);
        //}

        private async void msbtnOpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFile(mstxtFilePath, openFileDialog1))
            {
                
                form.ResetResultTextBox();
                form.ResetImages();
                await ProcessImage(mstxtFilePath);
            }
        }

        
        private void ResetResultTextBox()
        {
            txtResult.Text = "";
            txtResult2.Text = "";
            txtResult3.Text = "";
        }
        private void ResetImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void AppendTextBoxLine(string appendValue)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.AppendText(Environment.NewLine);
            }
            txtResult.AppendText(appendValue);
        }

        private void AppendTextBoxLine2(string appendValue)
        {
            if (txtResult2.Text.Length > 0)
            {
                txtResult2.AppendText(Environment.NewLine);
            }
            txtResult2.AppendText(appendValue);
        }

        private void AppendTextBoxLine3(string appendValue)
        {
            if (txtResult3.Text.Length > 0)
            {
                txtResult3.AppendText(Environment.NewLine);
            }
            txtResult3.AppendText(appendValue);
        }

        private void SetErrorMessage(string errorMessage)
        {
            
            MetroSetMessageBox.Show(new FormMessageBox(), errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetImage(string imagePath)
        {
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void SetImage2(string imagePath)
        {
            pictureBox2.Image = Image.FromFile(imagePath);
        }

        private void SetImage3(string imagePath)
        {
            pictureBox3.Image = Image.FromFile(imagePath);
        }

        private string GetSelectedFolder()
        {
            var strFilePath = mstxtFilePath.Text;
            var strFolderPath = Path.GetDirectoryName(strFilePath)??"";
            return strFolderPath;
        }

        private static async Task ProcessImage(MetroSetTextBox textboxFilePath)
        {
            try
            {
                // Get image
                string imageFile = textboxFilePath.Text;

                // Authenticate Computer Vision client
                ApiKeyServiceClientCredentials credentials = new ApiKeyServiceClientCredentials(cogSvcKey);
                cvClient = new ComputerVisionClient(credentials)
                {
                    Endpoint = cogSvcEndpoint
                };

                // Analyze image
                await AnalyzeImage(imageFile);

                // Get thumbnail
                await GetThumbnail(imageFile);

                // Detect faces in an image
                await AnalyzeFaces(imageFile);
            }
            catch (Exception ex)
            {
                form.SetErrorMessage(ex.Message);
            }
        }

        private static async Task AnalyzeImage(string imageFile)
        {
            Console.WriteLine($"Analyzing {imageFile}");

            // Specify features to be retrieved
            List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>()
            {
                VisualFeatureTypes.Description,
                VisualFeatureTypes.Tags,
                VisualFeatureTypes.Categories,
                VisualFeatureTypes.Brands,
                VisualFeatureTypes.Objects,
                VisualFeatureTypes.Adult
            };


            // Get image analysis
            using (var imageData = File.OpenRead(imageFile))
            {
                var analysis = await cvClient.AnalyzeImageInStreamAsync(imageData, features);

                // get image captions
                foreach (var caption in analysis.Description.Captions)
                {
                    Console.WriteLine($"Description: {caption.Text} (confidence: {caption.Confidence.ToString("P")})");
                    form.AppendTextBoxLine($"Description: {caption.Text} (confidence: {caption.Confidence.ToString("P")})");
                }

                // Get image tags
                if (analysis.Tags.Count > 0)
                {
                    Console.WriteLine("Tags:");
                    foreach (var tag in analysis.Tags)
                    {
                        Console.WriteLine($" -{tag.Name} (confidence: {tag.Confidence.ToString("P")})");
                        form.AppendTextBoxLine($" -{tag.Name} (confidence: {tag.Confidence.ToString("P")})");
                    }
                }


                // Get image categories (including celebrities and landmarks)
                List<LandmarksModel> landmarks = new List<LandmarksModel> { };
                List<CelebritiesModel> celebrities = new List<CelebritiesModel> { };
                Console.WriteLine("Categories:");
                foreach (var category in analysis.Categories)
                {
                    // Print the category
                    Console.WriteLine($" -{category.Name} (confidence: {category.Score.ToString("P")})");
                    form.AppendTextBoxLine($" -{category.Name} (confidence: {category.Score.ToString("P")})");

                    // Get landmarks in this category
                    if (category.Detail?.Landmarks != null)
                    {
                        foreach (LandmarksModel landmark in category.Detail.Landmarks)
                        {
                            if (!landmarks.Any(item => item.Name == landmark.Name))
                            {
                                landmarks.Add(landmark);
                            }
                        }
                    }

                    // Get celebrities in this category
                    if (category.Detail?.Celebrities != null)
                    {
                        foreach (CelebritiesModel celebrity in category.Detail.Celebrities)
                        {
                            if (!celebrities.Any(item => item.Name == celebrity.Name))
                            {
                                celebrities.Add(celebrity);
                            }
                        }
                    }
                }

                // If there were landmarks, list them
                if (landmarks.Count > 0)
                {
                    Console.WriteLine("Landmarks:");
                    form.AppendTextBoxLine("Landmarks:");
                    foreach (LandmarksModel landmark in landmarks)
                    {
                        Console.WriteLine($" -{landmark.Name} (confidence: {landmark.Confidence.ToString("P")})");
                        form.AppendTextBoxLine($" -{landmark.Name} (confidence: {landmark.Confidence.ToString("P")})");
                    }
                }

                // If there were celebrities, list them
                if (celebrities.Count > 0)
                {
                    Console.WriteLine("Celebrities:");
                    foreach (CelebritiesModel celebrity in celebrities)
                    {
                        Console.WriteLine($" -{celebrity.Name} (confidence: {celebrity.Confidence.ToString("P")})");
                        form.AppendTextBoxLine($" -{celebrity.Name} (confidence: {celebrity.Confidence.ToString("P")})");
                    }
                }


                // Get brands in the image
                if (analysis.Brands.Count > 0)
                {
                    Console.WriteLine("Brands:");
                    foreach (var brand in analysis.Brands)
                    {
                        Console.WriteLine($" -{brand.Name} (confidence: {brand.Confidence.ToString("P")})");
                        form.AppendTextBoxLine($" -{brand.Name} (confidence: {brand.Confidence.ToString("P")})");
                    }
                }


                // Get objects in the image
                if (analysis.Objects.Count > 0)
                {
                    Console.WriteLine("Objects in image:");
                    form.AppendTextBoxLine("Objects in image:");

                    // Prepare image for drawing
                    Image image = Image.FromFile(imageFile);
                    Graphics graphics = Graphics.FromImage(image);
                    Pen pen = new Pen(Color.Cyan, 3);
                    Font font = new Font("Arial", 4);
                    SolidBrush brush = new SolidBrush(Color.Cyan);

                    foreach (var detectedObject in analysis.Objects)
                    {
                        // Print object name
                        Console.WriteLine($" -{detectedObject.ObjectProperty} (confidence: {detectedObject.Confidence.ToString("P")})");
                        form.AppendTextBoxLine($" -{detectedObject.ObjectProperty} (confidence: {detectedObject.Confidence.ToString("P")})");

                        // Draw object bounding box
                        var r = detectedObject.Rectangle;
                        Rectangle rect = new Rectangle(r.X, r.Y, r.W, r.H);
                        graphics.DrawRectangle(pen, rect);
                        graphics.DrawString(detectedObject.ObjectProperty, font, brush, r.X, r.Y);

                    }
                    // Save annotated image
                    string folderPath = $"{Path.GetDirectoryName(imageFile)??"."}\\demoOutput";
                    string filename = Path.GetFileNameWithoutExtension(imageFile);
                    string fileExt = Path.GetExtension(imageFile);
                    System.IO.Directory.CreateDirectory(folderPath);
                    var dtNow = DateTime.Now.ToString("yyyyMMdd.hhmmss");
                    
                    string savingFilePath = Path.Combine(folderPath, $"{filename}.{dtNow}.{fileExt}");
                    
                    image.Save(savingFilePath);
                    Console.WriteLine("  Results saved in " + savingFilePath);
                    form.AppendTextBoxLine("  Results saved in " + savingFilePath);
                    form.SetImage(savingFilePath);
                }


                // Get moderation ratings
                string ratings = $"Ratings:\n -Adult: {analysis.Adult.IsAdultContent}\n -Racy: {analysis.Adult.IsRacyContent}\n -Gore: {analysis.Adult.IsGoryContent}";
                Console.WriteLine(ratings);
                form.AppendTextBoxLine($"Ratings:");
                form.AppendTextBoxLine($" -Adult: {analysis.Adult.IsAdultContent}");
                form.AppendTextBoxLine($" -Racy: {analysis.Adult.IsRacyContent}");
                form.AppendTextBoxLine($" -Gore: {analysis.Adult.IsGoryContent}");
            }

        }

        private static async Task GetThumbnail(string imageFile)
        {
            Console.WriteLine("Generating thumbnail");
            form.AppendTextBoxLine3("Generating thumbnail");

            // Generate a thumbnail
            using (var imageData = File.OpenRead(imageFile))
            {
                // Get thumbnail data
                var thumbnailStream = await cvClient.GenerateThumbnailInStreamAsync(100, 100, imageData, true);

                // Save thumbnail image
                string folderPath = Path.Combine(Path.GetDirectoryName(imageFile)??".","demoOutput");
                string filename = Path.GetFileNameWithoutExtension(imageFile);
                string fileExt = Path.GetExtension(imageFile);
                System.IO.Directory.CreateDirectory(folderPath);
                var dtNow = DateTime.Now.ToString("yyyyMMdd.hhmmss");
                String output_file = $"{folderPath}\\{filename}.{dtNow}.{fileExt}";

                string thumbnailFileName = $"{filename}.thumbnail.{dtNow}.png";
                string savingthumbnailFilePath = Path.Combine(folderPath, thumbnailFileName);
                using (Stream thumbnailFile = File.Create(savingthumbnailFilePath))
                {
                    thumbnailStream.CopyTo(thumbnailFile);
                }

                Console.WriteLine($"Thumbnail saved in {savingthumbnailFilePath}");
                form.AppendTextBoxLine3($"Thumbnail saved in {savingthumbnailFilePath}");
                form.SetImage3(savingthumbnailFilePath);
            }

        }

        static async Task AnalyzeFaces(string imageFile)
        {
            Console.WriteLine($"Analyzing {imageFile}");
            form.AppendTextBoxLine2($"Analyzing {imageFile}");

            // Specify features to be retrieved (faces)
            List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>()
            {
                VisualFeatureTypes.Faces
            };

            // Get image analysis
            using (var imageData = File.OpenRead(imageFile))
            {
                var analysis = await cvClient.AnalyzeImageInStreamAsync(imageData, features);

                // Get faces
                if (analysis.Faces.Count > 0)
                {
                    Console.WriteLine($"{analysis.Faces.Count} faces detected.");
                    form.AppendTextBoxLine2($"{analysis.Faces.Count} faces detected.");

                    // Prepare image for drawing
                    Image image = Image.FromFile(imageFile);
                    Graphics graphics = Graphics.FromImage(image);
                    Pen pen = new Pen(Color.LightGreen, 3);
                    Font font = new Font("Arial", 4);
                    SolidBrush brush = new SolidBrush(Color.LightGreen);

                    // Draw and annotate each face
                    foreach (var face in analysis.Faces)
                    {
                        var r = face.FaceRectangle;
                        Rectangle rect = new Rectangle(r.Left, r.Top, r.Width, r.Height);
                        graphics.DrawRectangle(pen, rect);
                        string annotation = $"Person aged approximately {face.Age}";
                        graphics.DrawString(annotation, font, brush, r.Left, r.Top);
                    }

                    // get the output filename
                    string folderPath = Path.Combine(Path.GetDirectoryName(imageFile) ?? ".", "demoOutput");
                    string filename = Path.GetFileNameWithoutExtension(imageFile);
                    string fileExt = Path.GetExtension(imageFile);
                    System.IO.Directory.CreateDirectory(folderPath);
                    var dtNow = DateTime.Now.ToString("yyyyMMdd.hhmmss");
                    String output_file = $"{folderPath}\\{filename}.{dtNow}.{fileExt}";

                    string fdFileName = $"{filename}.facedetect.{dtNow}.png";
                    string savingfdFilePath = Path.Combine(folderPath, fdFileName);

                    // Save annotated image
                    //String output_file = "detected_faces.jpg";
                    image.Save(savingfdFilePath);
                    Console.WriteLine(" Results saved in " + savingfdFilePath);
                    form.AppendTextBoxLine2(" Results saved in " + savingfdFilePath);
                    form.SetImage2(savingfdFilePath);
                }
            }
        }

        private static bool OpenFile(MetroSetTextBox mstextboxFilePath, OpenFileDialog openFileDialog)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog.FilterIndex = 2;
            //openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "";
            if (string.IsNullOrEmpty(openFileDialog.Filter))
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;

                foreach (var c in codecs)
                {
                    if (!string.IsNullOrEmpty(c.CodecName))
                    {
                        string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                        openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, codecName, c.FilenameExtension?.ToLower());
                        sep = "|";
                    }
                }
                //openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, "All Files", "*.*");
                openFileDialog.DefaultExt = "*.*"; // Default file extension
            }
                 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                
                mstextboxFilePath.Text = filePath;
                form.SetImage(filePath);
                return true;
            }
            //}
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            return false;
        }

        private void cboxZoomIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxZoomIn.Checked)
            {
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }


    }
}
