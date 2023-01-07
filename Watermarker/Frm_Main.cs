using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Simple_Image_Watermarker
{
    public partial class Frm_Main : Form
    {

        void LoadAll()
        {
            // Load All
            WatermarkMode wm = (WatermarkMode)Properties.Settings.Default.mode;
            if (wm == WatermarkMode.WholeFolder)
            {
                rbFolder.Checked = true;
                mode = WatermarkMode.WholeFolder;

                tbImgDirPath.Text = Properties.Settings.Default.FolderPath;
                
                folderBrowserDialogImages.SelectedPath = Properties.Settings.Default.FolderPath;
            }
            else
            {
                rbSingleFile.Checked = true;
                mode = WatermarkMode.SingleFile;

                tbImgDirPath.Text = Properties.Settings.Default.ImagePath;

                if (File.Exists(Properties.Settings.Default.ImagePath))
                {
                    openFileDialogImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.ImagePath);
                    openFileDialogImage.FileName = Path.GetFileName(Properties.Settings.Default.ImagePath);
                }


            }

            WatermarkPosition wp = (WatermarkPosition)Properties.Settings.Default.position;

            switch (wp)
            {
                case WatermarkPosition.TopLeft:
                    rbTL.Checked = true;
                    position = WatermarkPosition.TopLeft;
                    break;
                case WatermarkPosition.TopMid:
                    rbTM.Checked = true;
                    position = WatermarkPosition.TopMid;
                    break;
                case WatermarkPosition.TopRight:
                    rbTR.Checked = true;
                    position = WatermarkPosition.TopRight;
                    break;
                case WatermarkPosition.MidLeft:
                    rbML.Checked = true;
                    position = WatermarkPosition.MidLeft;
                    break;
                case WatermarkPosition.Center:
                    rbC.Checked = true;
                    position = WatermarkPosition.Center;
                    break;
                case WatermarkPosition.MidRight:
                    rbMR.Checked = true;
                    position = WatermarkPosition.MidRight;
                    break;
                case WatermarkPosition.BottomLeft:
                    rbBL.Checked = true;
                    position = WatermarkPosition.BottomLeft;
                    break;
                case WatermarkPosition.BottomMid:
                    rbBM.Checked = true;
                    position = WatermarkPosition.BottomMid;
                    break;
                case WatermarkPosition.BottomRight:
                    rbBR.Checked = true;
                    position = WatermarkPosition.BottomRight;
                    break;
                case WatermarkPosition.Repeat:
                    rbRep.Checked = true;
                    position = WatermarkPosition.Repeat;
                    break;
                default:
                    break;
            }

            tbCopyright.Text = Properties.Settings.Default.copyRightString;
            tbSuffix.Text = Properties.Settings.Default.suffix;
            tbWatermarkFolderName.Text = Properties.Settings.Default.watermarkedFolderName;


            tbWatermarkImage.Text = Properties.Settings.Default.watermarkImagePath;

            if (File.Exists(Properties.Settings.Default.watermarkImagePath))
            {
                openFileDialogWatermarkImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.watermarkImagePath);
                openFileDialogWatermarkImage.FileName = Path.GetFileName(Properties.Settings.Default.watermarkImagePath);
            }


            numericUpDownMargin.Value = Convert.ToDecimal(Properties.Settings.Default.margin);
            numericUpDownRotation.Value = Convert.ToDecimal(Properties.Settings.Default.watermarkRot);
            trackBarOpacity.Value = Properties.Settings.Default.opacity;
            trackBarScale.Value = Properties.Settings.Default.watermarkScale;
            
            
        }

        public Frm_Main()
        {
            InitializeComponent();

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Simple Image Watermarker | v" + TrimTheEnd(version, ".0");

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }



            LoadAll();


            // Image files|*.bmp;*.dib;*.rle;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|BMP files (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|JPEG files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF files (*.gif)|*.gif|TIFF files (*.tif;*.tiff)|*.tif;*.tiff|PNG files (*.png)|*.png
            //Console.WriteLine(GetImageFilter());
            openFileDialogImage.Filter = "Image files|*.bmp;*.dib;*.rle;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|BMP files (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|JPEG files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF files (*.gif)|*.gif|TIFF files (*.tif;*.tiff)|*.tif;*.tiff|PNG files (*.png)|*.png";
            openFileDialogWatermarkImage.Filter = "Image files|*.bmp;*.dib;*.rle;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|BMP files (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|JPEG files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF files (*.gif)|*.gif|TIFF files (*.tif;*.tiff)|*.tif;*.tiff|PNG files (*.png)|*.png";
        }

        enum WatermarkMode
        {
            SingleFile,
            WholeFolder
        }

        enum WatermarkPosition
        {
            TopLeft,
            TopMid,
            TopRight,
            MidLeft,
            Center,
            MidRight,
            BottomLeft,
            BottomMid,
            BottomRight,
            Repeat
        }

        WatermarkMode mode = WatermarkMode.WholeFolder;
        WatermarkPosition position = WatermarkPosition.BottomLeft;


        public static Image RotateImage(Image image, float angle)
        {
            // Calculate the size of the rotated image
            double radians = angle * Math.PI / 180;
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));
            int width = (int)(image.Width * cos + image.Height * sin);
            int height = (int)(image.Width * sin + image.Height * cos);

            // Create a new empty bitmap to hold rotated image
            Bitmap rotatedImage = new Bitmap(width, height);

            // Make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Clear the image with transparent background
                g.Clear(Color.Transparent);

                // Set the interpolation mode to high quality
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Translate the image to the center of the output bitmap
                g.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2);

                // Rotate the image
                g.RotateTransform(angle);

                // Translate the image back to its original position
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);

                // Draw the image onto the graphics object
                g.DrawImage(image, 0, 0, image.Width, image.Height);
            }

            // Return the image
            return (Image)rotatedImage;
        }



        private void AddWatermark(String imagePath, String watermarkImagePath, float opacity, float scale, int margin, String suffix, String folderName)
        {
            String fullPathImg = Path.GetFullPath(imagePath);
            String pathImg = Path.GetDirectoryName(fullPathImg);
            String pathWatermarked = Path.Combine(pathImg, folderName);

            String fileNameImg = Path.GetFileNameWithoutExtension(fullPathImg);
            String fileExtensionImg = Path.GetExtension(fullPathImg);

            if (!Directory.Exists(pathWatermarked))
            {
                Directory.CreateDirectory(pathWatermarked);
            }

            String watermarkedFileNameAndExt = fileNameImg + suffix + fileExtensionImg;

            String fullPathWatermarkedImage = Path.Combine(pathWatermarked, watermarkedFileNameAndExt);

            // Load the source image and the watermark image
            using (Image image = Image.FromFile(imagePath))
            using (Image watermarkImage = RotateImage(Image.FromFile(watermarkImagePath), Convert.ToSingle(numericUpDownRotation.Value)))
            {
                // Calculate the scale factor for the watermark
                float finalScale = scale;
                if (scale * watermarkImage.Width > image.Width || scale * watermarkImage.Height > image.Height)
                {
                    float scaleX = (float)image.Width / watermarkImage.Width;
                    float scaleY = (float)image.Height / watermarkImage.Height;
                    finalScale = Math.Min(scaleX, scaleY);
                }

                // Calculate the new size of the watermark image based on the scale factor
                int width = (int)(watermarkImage.Width * finalScale);
                int height = (int)(watermarkImage.Height * finalScale);

                // Create a new bitmap to hold the resized watermark image
                using (Bitmap resizedWatermark = new Bitmap(width, height))
                {
                    // Draw the watermark image onto the bitmap using the specified scale
                    using (Graphics graphics = Graphics.FromImage(resizedWatermark))
                    {
                        graphics.DrawImage(watermarkImage, 0, 0, width, height);
                    }

                    // Create a Graphics object for the source image
                    using (Graphics imageGraphics = Graphics.FromImage(image))
                    {
                        // Create a ColorMatrix object and set the alpha value
                        ColorMatrix colorMatrix = new ColorMatrix();
                        colorMatrix.Matrix33 = opacity;

                        // Create an ImageAttributes object and set the ColorMatrix
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        // Calculate the position of the watermark image
                        int x = 0;
                        int y = 0;

                        int anchorOffsetX = width / 2;
                        int anchorOffsetY = height / 2;

                        x = (image.Width / 2) - anchorOffsetX;
                        y = (image.Height / 2) - anchorOffsetY;

                        while (x > (width + margin) * -1)
                        {
                            y = (image.Height / 2) - anchorOffsetY;
                            //int ccc = 0;
                            while (y > (height + margin) * -1)
                            {
                                // Draw the watermark image onto the source image using the DrawImage method
                                imageGraphics.DrawImage(resizedWatermark, new Rectangle(x, y, width, height),
                                    0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

                                y -= (height + margin);
                            }

                            y = (image.Height / 2) - anchorOffsetY;

                            y += (height + margin);

                            //ccc = 0;
                            while (y < (height + margin) + image.Height)
                            {
                                // Draw the watermark image onto the source image using the DrawImage method
                                imageGraphics.DrawImage(resizedWatermark, new Rectangle(x, y, width, height),
                                    0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

                                y += (height + margin);
                            }

                            x -= (width + margin);
                        }

                        x = (image.Width / 2) - anchorOffsetX;
                        y = (image.Height / 2) - anchorOffsetY;

                        x += (width + margin);

                        while (x < (width + margin) + image.Width)
                        {
                            y = (image.Height / 2) - anchorOffsetY;
                            //int ccc = 0;
                            while (y > (height + margin) * -1)
                            {
                                // Draw the watermark image onto the source image using the DrawImage method
                                imageGraphics.DrawImage(resizedWatermark, new Rectangle(x, y, width, height),
                                    0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

                                y -= (height + margin);
                            }

                            y = (image.Height / 2) - anchorOffsetY;

                            y += (height + margin);

                            //ccc = 0;
                            while (y < (height + margin) + image.Height)
                            {
                                // Draw the watermark image onto the source image using the DrawImage method
                                imageGraphics.DrawImage(resizedWatermark, new Rectangle(x, y, width, height),
                                    0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

                                y += (height + margin);
                            }

                            x += (width + margin);
                        }
                    }
                }
                if (!String.IsNullOrWhiteSpace(tbCopyright.Text))
                {
                    EditExifCopyright(image, tbCopyright.Text);
                }

                image.Save(fullPathWatermarkedImage);
            }


        }

        //My SetProperty code... (for ASCII property items only!)
        //Exif 2.2 requires that ASCII property items terminate with a null (0x00).
        private void SetProperty(ref System.Drawing.Imaging.PropertyItem prop, int iId, string sTxt)
        {
            int iLen = sTxt.Length + 1;
            byte[] bTxt = new Byte[iLen];
            for (int i = 0; i < iLen - 1; i++)
                bTxt[i] = (byte)sTxt[i];
            bTxt[iLen - 1] = 0x00;
            prop.Id = iId;
            prop.Type = 2;
            prop.Value = bTxt;
            prop.Len = iLen;
        }

        public void EditExifCopyright(Image image, string copyright)
        {
            System.Drawing.Imaging.PropertyItem prop = image.PropertyItems[0];
            SetProperty(ref prop, 33432, copyright);
            image.SetPropertyItem(prop);
        }

        private void AddWatermark(String imagePath, String watermarkImagePath, WatermarkPosition position, float opacity, float scale, int margin, String suffix, String folderName)
        {
            String fullPathImg = Path.GetFullPath(imagePath);
            String pathImg = Path.GetDirectoryName(fullPathImg);
            String pathWatermarked = Path.Combine(pathImg, folderName);

            String fileNameImg = Path.GetFileNameWithoutExtension(fullPathImg);
            String fileExtensionImg = Path.GetExtension(fullPathImg);

            if (!Directory.Exists(pathWatermarked))
            {
                Directory.CreateDirectory(pathWatermarked);
            }

            String watermarkedFileNameAndExt = fileNameImg + suffix + fileExtensionImg;

            String fullPathWatermarkedImage = Path.Combine(pathWatermarked, watermarkedFileNameAndExt);

            // Load the source image and the watermark image
            using (Image image = Image.FromFile(imagePath))
            using (Image watermarkImage = RotateImage(Image.FromFile(watermarkImagePath), Convert.ToSingle(numericUpDownRotation.Value)))
            {
                // Calculate the scale factor for the watermark
                float finalScale = scale;
                if (scale * watermarkImage.Width > image.Width || scale * watermarkImage.Height > image.Height)
                {
                    float scaleX = (float)image.Width / watermarkImage.Width;
                    float scaleY = (float)image.Height / watermarkImage.Height;
                    finalScale = Math.Min(scaleX, scaleY);
                }

                // Calculate the new size of the watermark image based on the scale factor
                int width = (int)(watermarkImage.Width * finalScale);
                int height = (int)(watermarkImage.Height * finalScale);

                // Create a new bitmap to hold the resized watermark image
                using (Bitmap resizedWatermark = new Bitmap(width, height))
                {
                    // Draw the watermark image onto the bitmap using the specified scale
                    using (Graphics graphics = Graphics.FromImage(resizedWatermark))
                    {
                        graphics.DrawImage(watermarkImage, 0, 0, width, height);
                    }

                    // Create a Graphics object for the source image
                    using (Graphics imageGraphics = Graphics.FromImage(image))
                    {
                        // Create a ColorMatrix object and set the alpha value
                        ColorMatrix colorMatrix = new ColorMatrix();
                        colorMatrix.Matrix33 = opacity;

                        // Create an ImageAttributes object and set the ColorMatrix
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        // Calculate the position of the watermark image
                        int x = 0;
                        int y = 0;
                        switch (position)
                        {
                            case WatermarkPosition.TopLeft:
                                x = 0;
                                y = 0;

                                x += margin;
                                y += margin;

                                break;
                            case WatermarkPosition.TopMid:
                                x = (image.Width - width) / 2;
                                y = 0;

                                y += margin;

                                break;
                            case WatermarkPosition.TopRight:
                                x = image.Width - width;
                                y = 0;

                                x -= margin;
                                y += margin;

                                break;
                            case WatermarkPosition.MidLeft:
                                x = 0;
                                y = (image.Height - height) / 2;

                                x += margin;

                                break;
                            case WatermarkPosition.Center:
                                x = (image.Width - width) / 2;
                                y = (image.Height - height) / 2;
                                break;
                            case WatermarkPosition.MidRight:
                                x = image.Width - width;
                                y = (image.Height - height) / 2;

                                x -= margin;

                                break;
                            case WatermarkPosition.BottomLeft:
                                x = 0;
                                y = image.Height - height;

                                x += margin;
                                y -= margin;

                                break;
                            case WatermarkPosition.BottomMid:
                                x = (image.Width - width) / 2;
                                y = image.Height - height;

                                y -= margin;

                                break;
                            case WatermarkPosition.BottomRight:
                                x = image.Width - width;
                                y = image.Height - height;

                                x -= margin;
                                y -= margin;

                                break;
                            case WatermarkPosition.Repeat:
                                AddWatermark(imagePath, watermarkImagePath, opacity, scale, margin, tbSuffix.Text, tbWatermarkFolderName.Text);
                                return;
                                //break;
                                
                        }

                        // Draw the watermark image onto the source image using the DrawImage method
                        imageGraphics.DrawImage(resizedWatermark, new Rectangle(x, y, width, height),
                            0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                    }
                }

                if (!String.IsNullOrWhiteSpace(tbCopyright.Text))
                {
                    EditExifCopyright(image, tbCopyright.Text);
                }

                image.Save(fullPathWatermarkedImage);
            }

        }

        
        private void trackBarOpacity_ValueChanged(object sender, EventArgs e)
        {
            lblOpacity.Text = "Opacity: " + trackBarOpacity.Value.ToString("0") + "%";

            Properties.Settings.Default.opacity = trackBarOpacity.Value;
            Properties.Settings.Default.Save();
        }

        private void trackBarScale_ValueChanged(object sender, EventArgs e)
        {
            lblScale.Text = "Watermark Scale: " + trackBarScale.Value.ToString("0") + "%";

            Properties.Settings.Default.watermarkScale = trackBarScale.Value;
            Properties.Settings.Default.Save();
        }

        #region PositionRadioButtons
        private void rbTL_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.TopLeft;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbTM_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.TopMid;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();

            }
        }

        private void rbTR_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.TopRight;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbML_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.MidLeft;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.Center;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbMR_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.MidRight;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbBL_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.BottomLeft;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbBM_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.BottomMid;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbBR_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.BottomRight;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }

        private void rbRep_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                position = WatermarkPosition.Repeat;

                Properties.Settings.Default.position = (int)position;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        private void btnOpenImageDirFile_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case WatermarkMode.SingleFile:
                    openFileDialogImage.ShowDialog();
                    break;
                case WatermarkMode.WholeFolder:
                    DialogResult dr = folderBrowserDialogImages.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        tbImgDirPath.Text = folderBrowserDialogImages.SelectedPath;
                        lblProgress.Text = $"0/{Directory.GetFiles(tbImgDirPath.Text).Where(x => isImageExt(x)).Count()}";

                        Properties.Settings.Default.FolderPath = folderBrowserDialogImages.SelectedPath;

                        folderBrowserDialogImages.SelectedPath = Properties.Settings.Default.FolderPath;

                        Properties.Settings.Default.Save();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnOpenWatermarkFile_Click(object sender, EventArgs e)
        {
            openFileDialogWatermarkImage.ShowDialog();
        }

        bool isImageExt(string path)
        {
            if (!Path.HasExtension(path))
            {
                return false;
            }

            string ext = Path.GetExtension(path);

            string pattern = @"(?i)\.(bmp|dib|rle|jpg|jpeg|jpe|jfif|gif|tif|tiff|png)$";
            Regex regex = new Regex(pattern);

            bool containsMatch = regex.IsMatch(ext);

            if (containsMatch)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        List<string> fileList = new List<string>();
        private void btnStart_Click(object sender, EventArgs e)
        {
            //WatermarkPosition position = WatermarkPosition.BottomRight; // Change this to the desired position
            float scale = (float)trackBarScale.Value / 100f;
            float opacity = (float)trackBarOpacity.Value / 100f;

            if (String.IsNullOrWhiteSpace(tbWatermarkFolderName.Text))
            {
                MessageBox.Show("Watermarked Folder-Name cannot be empty!");
                tbWatermarkFolderName.Text = "watermarked";
                return;
            }

            if (!File.Exists(tbWatermarkImage.Text))
            {
                MessageBox.Show($"Provided Watermark Image \"{tbWatermarkImage.Text}\" does not exist!");
                return;
            }

            if (!isImageExt(tbWatermarkImage.Text))
            {
                MessageBox.Show($"Provided Watermark Image \"{tbWatermarkImage.Text}\" has unsupported Extension!");
                return;
            }



            if (mode == WatermarkMode.WholeFolder)
            {
                if (!Directory.Exists(tbImgDirPath.Text))
                {
                    MessageBox.Show($"Provided Image Folder \"{tbImgDirPath.Text}\" does not exist!");
                    return;
                }

                fileList = new List<string>();

                fileList = Directory.GetFiles(tbImgDirPath.Text).Where(x => isImageExt(x)).ToList();

                mainPnl.Enabled = false;
                btnStart.Enabled = false;

                lblProgress.Text = $"0/{fileList.Count}";
                int count = 0;
                var t = Task.Run(() => {
                int amount = Directory.GetFiles(tbImgDirPath.Text).Where(x => isImageExt(x)).Count();
                    foreach (string file in fileList)
                    {
                        AddWatermark(file, tbWatermarkImage.Text, position, opacity, scale, Convert.ToInt32(numericUpDownMargin.Value), tbSuffix.Text, tbWatermarkFolderName.Text);
                        
                        count++;
                        this.BeginInvoke((Action)(() => {
                            lblProgress.Text = $"{count}/{amount}";
                        }));
                        
                    }

                    this.BeginInvoke((Action)(() => {
                        mainPnl.Enabled = true;
                        btnStart.Enabled = true;
                    }));

                    
                });

                

            }
            else
            {
                if (!File.Exists(tbImgDirPath.Text))
                {
                    MessageBox.Show($"Provided Image \"{tbImgDirPath.Text}\" does not exist!");
                    return;
                }

                if (!isImageExt(tbImgDirPath.Text))
                {
                    MessageBox.Show($"Provided Image \"{tbImgDirPath.Text}\" has unsupported Extension!");
                    return;
                }

                mainPnl.Enabled = false;
                btnStart.Enabled = false;
                lblProgress.Text = "0/1";
                AddWatermark(tbImgDirPath.Text, tbWatermarkImage.Text, position, opacity, scale, Convert.ToInt32(numericUpDownMargin.Value), tbSuffix.Text, tbWatermarkFolderName.Text);
                lblProgress.Text = "1/1";
                mainPnl.Enabled = true;
                btnStart.Enabled = true;

            }

            // Save all
            Properties.Settings.Default.mode = (int)mode;
            Properties.Settings.Default.position = (int)position;
            Properties.Settings.Default.copyRightString = tbCopyright.Text;
            Properties.Settings.Default.suffix = tbSuffix.Text;
            Properties.Settings.Default.watermarkedFolderName = tbWatermarkFolderName.Text;

            Properties.Settings.Default.watermarkImagePath = tbWatermarkImage.Text;
            if (File.Exists(Properties.Settings.Default.watermarkImagePath))
            {
                openFileDialogWatermarkImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.watermarkImagePath);
                openFileDialogWatermarkImage.FileName = Path.GetFileName(Properties.Settings.Default.watermarkImagePath);
            }

            switch (mode)
            {
                case WatermarkMode.SingleFile:
                    Properties.Settings.Default.ImagePath = tbImgDirPath.Text;

                    if (File.Exists(Properties.Settings.Default.ImagePath))
                    {
                        openFileDialogImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.ImagePath);
                        openFileDialogImage.FileName = Path.GetFileName(Properties.Settings.Default.ImagePath);
                    }

                    break;
                case WatermarkMode.WholeFolder:
                    Properties.Settings.Default.FolderPath = tbImgDirPath.Text;

                    folderBrowserDialogImages.SelectedPath = Properties.Settings.Default.FolderPath;

                    break;
                default:
                    break;
            }
            Properties.Settings.Default.margin = Convert.ToInt32(numericUpDownMargin.Value);
            Properties.Settings.Default.watermarkRot = Convert.ToInt32(numericUpDownRotation.Value);
            Properties.Settings.Default.opacity = trackBarOpacity.Value;
            Properties.Settings.Default.watermarkScale = trackBarScale.Value;

            Properties.Settings.Default.Save();

        }

        private void rbSingleFile_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                mode = WatermarkMode.SingleFile;

                Properties.Settings.Default.mode = (int)mode;
                Properties.Settings.Default.Save();
            }

        }

        private void rbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                mode = WatermarkMode.WholeFolder;

                Properties.Settings.Default.mode = (int)mode;
                Properties.Settings.Default.Save();
            }

            

        }

        private void openFileDialogImage_FileOk(object sender, CancelEventArgs e)
        {
            tbImgDirPath.Text = openFileDialogImage.FileName;
            lblProgress.Text = "0/1";

            Properties.Settings.Default.ImagePath = openFileDialogImage.FileName;
            if (File.Exists(Properties.Settings.Default.ImagePath))
            {
                openFileDialogImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.ImagePath);
                openFileDialogImage.FileName = Path.GetFileName(Properties.Settings.Default.ImagePath);
            }


            Properties.Settings.Default.Save();
        }

        private void openFileDialogWatermarkImage_FileOk(object sender, CancelEventArgs e)
        {
            tbWatermarkImage.Text = openFileDialogWatermarkImage.FileName;

            Properties.Settings.Default.watermarkImagePath = openFileDialogWatermarkImage.FileName;

            if (File.Exists(Properties.Settings.Default.watermarkImagePath))
            {
                openFileDialogWatermarkImage.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.watermarkImagePath);
                openFileDialogWatermarkImage.FileName = Path.GetFileName(Properties.Settings.Default.watermarkImagePath);
            }

            Properties.Settings.Default.Save();
        }

        private void numericUpDownMargin_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.margin = Convert.ToInt32(numericUpDownMargin.Value);
            Properties.Settings.Default.Save();
        }

        private void numericUpDownRotation_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.watermarkRot = Convert.ToInt32(numericUpDownRotation.Value);
            Properties.Settings.Default.Save();
        }

        private void tbFileFolder_DragDrop(object sender, DragEventArgs e)
        {
            
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                ((System.Windows.Forms.TextBox)sender).Text = files.First(); //select the first one 
        }

        private void tbFileFolder_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WaGi-Coding/Simple-Batch-Image-Watermarker");
        }

        public string TrimTheEnd(string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            if (result.EndsWith(trimString))
            {
                result = result.Substring(0, result.Length - trimString.Length);
            }

            return result;
        }

        private void mainPnl_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblMode;
            lblMode.Focus();
        }

        private void Frm_Main_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblMode;
            lblMode.Focus();
        }
    }
}
