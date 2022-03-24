// import namespaces
//using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
//using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Extensions.Configuration;
using System.Drawing.Imaging;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;

namespace AIDemo
{
    public partial class FormFaceService : Form
    {
        //private static ComputerVisionClient cvClient;
        private static string cogSvcEndpoint;
        private static string cogSvcKey;
        private static FormFaceService form = null;
        private static FaceClient faceClient;

        public FormFaceService()
        {
            InitializeComponent();
            form = this;
        }

        public string ImagePath1 
        { 
            get { return mstxtImagePath1.Text; } 
            set { mstxtImagePath1.Text = value; }
        }
        public string ImagePath2
        {
            get { return mstxtImagePath2.Text; }
            set { mstxtImagePath2.Text = value; }
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
                ApiKeyServiceClientCredentials credentials = new ApiKeyServiceClientCredentials(cogSvcKey);
                faceClient = new FaceClient(credentials)
                {
                    Endpoint = cogSvcEndpoint
                };
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DisplayError(ex.Message);
            }
        }

        private void msbtnOpenFile1_Click(object sender, EventArgs e)
        {
            OpenFile(mstxtImagePath1, pictureBox1, openFileDialog1);
        }

        private void msbtnOpenFile2_Click(object sender, EventArgs e)
        {
            OpenFile(mstxtImagePath2, pictureBox2, openFileDialog1);
        }

        private void DisplayError(string errorMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayInfo(string infoMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppendTextBox(string appendValue)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.AppendText(Environment.NewLine);
            }
            txtResult.AppendText(appendValue);
        }

        private void ResetTextBox()
        {
            txtResult.Text = "";
        }

        private void SetImage1(string imagePath)
        {
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void SetImage2(string imagePath)
        {
            pictureBox2.Image = Image.FromFile(imagePath);
        }

        private string GetSelectedFolder1()
        {
            var strFilePath = mstxtImagePath1.Text;
            var strFolderPath = Path.GetDirectoryName(strFilePath) ?? "";
            return strFolderPath;
        }
        private string GetSelectedFolder2()
        {
            var strFilePath = mstxtImagePath2.Text;
            var strFolderPath = Path.GetDirectoryName(strFilePath) ?? "";
            return strFolderPath;
        }

        private static bool OpenFile(MetroSetTextBox mstxtImagePath, PictureBox pictureBox, OpenFileDialog openFileDialog)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialog.FileName = "";
            if (string.IsNullOrEmpty(openFileDialog.Filter))
            {
                SetOpenFileFilter(openFileDialog);
            }
                 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                mstxtImagePath.Text = filePath;
                //form.SetImage(filePath);
                pictureBox.Image = Image.FromFile(filePath);
                return true;
            }
            return false;
        }

        private static void SetOpenFileFilter(OpenFileDialog openFileDialog)
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
            openFileDialog.DefaultExt = "*"; // Default file extension
        }

        private async void msbtnCallAPI_Click(object sender, EventArgs e)
        {
            try
            {
                ResetTextBox();
                await DetectFaces(mstxtImagePath1.Text);
            } catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        static async Task DetectFaces(string imageFile)
        {
            form.AppendTextBox($"Detecting faces in {imageFile}");

            // Specify facial features to be retrieved
            List<FaceAttributeType> features = new List<FaceAttributeType>
            {
                FaceAttributeType.Age,
                FaceAttributeType.Emotion,
                FaceAttributeType.Glasses
            };

            //recognitionModel: "recognition_04", detectionModel: "detection_03"
            List<FaceAttributeType> features_03 = new List<FaceAttributeType>
            {
                FaceAttributeType.Mask
            };

            // Get faces
            using (var imageData = File.OpenRead(imageFile))
            {
                var detected_faces = await faceClient.Face.DetectWithStreamAsync(imageData, returnFaceAttributes: features, recognitionModel: "recognition_04");
                form.AppendTextBox($"{detected_faces.Count} faces detected.");
                if (detected_faces.Count > 0)
                {
                    // Prepare image for drawing
                    Image image = Image.FromFile(imageFile);
                    Graphics graphics = Graphics.FromImage(image);
                    Pen pen = new Pen(Color.DeepSkyBlue, 3);
                    Font font = new("Times New Roman", 5, FontStyle.Regular);
                    SolidBrush brush = new SolidBrush(Color.Red);

                    // Draw and annotate each face
                    foreach (var face in detected_faces)
                    {
                        // Get face properties
                        form.AppendTextBox($"\nFace ID: {face.FaceId}");
                        form.AppendTextBox($" - Age: {face.FaceAttributes.Age}");
                        form.AppendTextBox($" - Emotions:");
                        foreach (var emotion in face.FaceAttributes.Emotion.ToRankedList())
                        {
                            form.AppendTextBox($"   - {emotion}");
                        }
                        form.AppendTextBox($" - Glasses: {face.FaceAttributes.Glasses}");

                        // Draw and annotate face
                        var r = face.FaceRectangle;
                        Rectangle rect = new Rectangle(r.Left, r.Top, r.Width, r.Height);
                        graphics.DrawRectangle(pen, rect);
                        string annotation = $"Face ID: {face.FaceId}";
                        graphics.DrawString(annotation, font, brush, r.Left, r.Top);
                        string age = $"Age: {face.FaceAttributes.Age}";
                        graphics.DrawString(age, font, brush, r.Left, r.Top-30);
                        string emot = $"{face.FaceAttributes.Emotion.ToRankedList().FirstOrDefault()}";
                        graphics.DrawString(emot, font, brush, r.Left, r.Top - 60);
                    }

                    // Save annotated image
                    form.SaveImage1(image, imageFile, "DetectFaces");
                }
            }
        }

        static async Task CompareFaces(string image1, string image2)
        {

            form.AppendTextBox($"Comparing faces in {image1} and {image2}");

            // Determine if the face in image 1 is also in image 2
            DetectedFace image_i_face;
            using (var image1Data = File.OpenRead(image1))
            {
                // Get the first face in image 1
                var image1_faces = await faceClient.Face.DetectWithStreamAsync(image1Data);
                if (image1_faces.Count > 0)
                {
                    image_i_face = image1_faces[0];
                    //form.AppendTextBox($"\nImage 1 - Face ID: {image_i_face.FaceId}");
                    Image img1 = Image.FromFile(image1);
                    Graphics graphics = Graphics.FromImage(img1);
                    Pen pen = new Pen(Color.DeepSkyBlue, 3);
                    var r = image_i_face.FaceRectangle;
                    Rectangle rect = new Rectangle(r.Left, r.Top, r.Width, r.Height);
                    graphics.DrawRectangle(pen, rect);
                    //String output_file = "face_to_match.jpg";
                    //img1.Save(output_file);
                    //form.AppendTextBox(" Results saved in " + output_file);
                    form.SaveImage1(img1, image1, "Face_to_Match");

                    //Get all the faces in image 2
                    using (var image2Data = File.OpenRead(image2))
                    {
                        var image2Faces = await faceClient.Face.DetectWithStreamAsync(image2Data);
                        form.AppendTextBox($"\nThere are {image2Faces.Count()} faces are found in second image.");
                        // Get faces
                        if (image2Faces.Count > 0)
                        {

                            var image2FaceIds = image2Faces.Select(f => f.FaceId).ToList<Guid?>();
                            
                            var similarFaces = await faceClient.Face.FindSimilarAsync((Guid)image_i_face.FaceId, faceIds: image2FaceIds);
                            var similarFaceIds = similarFaces.Select(f => f.FaceId).ToList<Guid?>();

                            form.AppendTextBox($"\nThere are {similarFaceIds.Count()} faces are matched.");

                            // Prepare image for drawing
                            Image img2 = Image.FromFile(image2);
                            Graphics graphics2 = Graphics.FromImage(img2);
                            Pen pen2 = new Pen(Color.DeepSkyBlue, 3);
                            Font font2 = new Font("Times New Roman", 5, FontStyle.Regular);
                            SolidBrush brush2 = new SolidBrush(Color.DeepSkyBlue);

                            // Draw and annotate each face
                            foreach (var face in image2Faces)
                            {
                                form.AppendTextBox($"\nImage 2 - Face ID: {face.FaceId}");
                                if (similarFaceIds.Contains(face.FaceId))
                                {
                                    var sConfidence = similarFaces.Where(f => f.FaceId == face.FaceId).Select(f => f.Confidence).FirstOrDefault();
                                    // Draw and annotate face
                                    var r2 = face.FaceRectangle;
                                    Rectangle rect2 = new Rectangle(r2.Left, r2.Top, r2.Width, r2.Height);
                                    graphics2.DrawRectangle(pen2, rect2);
                                    string Confidence = $"Confidence : {sConfidence}";
                                    form.AppendTextBox(Confidence);
                                    graphics2.DrawString(Confidence, font2, brush2, r2.Left, r2.Top-30);
                                    string annotation = $"Match! ";
                                    graphics2.DrawString(annotation, font2, brush2, r2.Left, r2.Top - 60);
                                }
                            }

                            // Save annotated image
                            //String output_file2 = "matched_faces.jpg";
                            //img2.Save(output_file2);
                            //form.AppendTextBox(" Results saved in " + output_file2);
                            form.SaveImage2(img2, image2, "Matched_Faces");
                        }
                    }

                }
            }
        }

        private void SaveImage1(Image image, string imageFile, string newFilename)
        {
            // get the output filename
            string folderPath = Path.Combine(Path.GetDirectoryName(imageFile) ?? ".", "demoOutput");
            string filename = Path.GetFileNameWithoutExtension(imageFile);
            string fileExt = Path.GetExtension(imageFile);
            System.IO.Directory.CreateDirectory(folderPath);
            var dtNow = DateTime.Now.ToString("yyyyMMdd.hhmmss");
            //String output_file = $"{folderPath}\\{filename}.{newFilename}.{dtNow}.{fileExt}";

            string fdFileName = $"{filename}.{newFilename}.{dtNow}.png";
            string savingfdFilePath = Path.Combine(folderPath, fdFileName);

            // Save annotated image
            image.Save(savingfdFilePath);
            form.AppendTextBox(" Results saved in " + savingfdFilePath);
            form.SetImage1(savingfdFilePath);
        }

        private void SaveImage2(Image image, string imageFile, string newFilename)
        {
            // get the output filename
            string folderPath = Path.Combine(Path.GetDirectoryName(imageFile) ?? ".", "demoOutput");
            string filename = Path.GetFileNameWithoutExtension(imageFile);
            string fileExt = Path.GetExtension(imageFile);
            System.IO.Directory.CreateDirectory(folderPath);
            var dtNow = DateTime.Now.ToString("yyyyMMdd.hhmmss");
            //String output_file = $"{folderPath}\\{filename}.{newFilename}.{dtNow}.{fileExt}";

            string fdFileName = $"{filename}.{newFilename}.{dtNow}.png";
            string savingfdFilePath = Path.Combine(folderPath, fdFileName);

            // Save annotated image
            image.Save(savingfdFilePath);
            form.AppendTextBox(" Results saved in " + savingfdFilePath);
            form.SetImage2(savingfdFilePath);
        }

        private async void msbtnFaceVerify_Click(object sender, EventArgs e)
        {         
            try
            {
                ResetTextBox();
                await CompareFaces(mstxtImagePath1.Text, mstxtImagePath2.Text);
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }
    }
}
