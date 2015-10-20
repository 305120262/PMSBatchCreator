using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Display;
using System.IO;
using ESRI.ArcGIS.Framework;

namespace PMSBatchCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            esriIPictureType ptype=esriIPictureType.esriIPicturePNG;
            switch (cbxPType.Text)
	        {
                case "BMP":
                    ptype=esriIPictureType.esriIPictureBitmap;
                    break;
                case "GIF":
                    ptype=esriIPictureType.esriIPictureGIF;
                    break;
                case "EMF":
                    ptype=esriIPictureType.esriIPictureEMF;
                    break;
                case "JPEG":
                    ptype=esriIPictureType.esriIPictureJPG;
                    break;
	        }
            try
            {
                int size = int.Parse(this.tbxSize.Text);
                string cat = this.tbxSet.Text;
                string folder = this.tbxFolder.Text;
                string target = this.tbxOutput.Text;
                IStyleGalleryStorage sgs = new StyleGalleryClass();
                sgs.TargetFile = target;
                IStyleGallery sg = sgs as IStyleGallery;
                int i = 0;
                foreach (string f in Directory.GetFiles(folder))
                {
                    string name = Path.GetFileNameWithoutExtension(f);
                    string pic = f;
                    if (cbIsScale.Checked)
                    {
                        pic = ScalePicture(f, size);
                    }
                    ISymbol sym = CreatePictureMarkerSymbol(ptype, pic, size) as ISymbol;
                    IStyleGalleryItem item = new StyleGalleryItemClass();
                    if (cbIsFileName.Checked)
                    {
                        item.Name = name;
                    }
                    else
                    {
                        item.Name = i.ToString();
                    }
                    item.Item = sym;
                    item.Category = cat;
                    sg.AddItem(item);
                    i++;
                }
                sg.SaveStyle(target, cat, "");
                MessageBox.Show("成功生成样式库。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.button1.Enabled = true;
        }

        private ESRI.ArcGIS.Display.IPictureMarkerSymbol CreatePictureMarkerSymbol(ESRI.ArcGIS.Display.esriIPictureType pictureType, System.String filename, System.Double markerSize)
        {

            // Set the Transparent background color for the Picture Marker symbol to white.
            ESRI.ArcGIS.Display.IRgbColor rgbColor = new ESRI.ArcGIS.Display.RgbColorClass();
            rgbColor.Red = 255;
            rgbColor.Green = 255;
            rgbColor.Blue = 255;

            // Create the Marker and assign properties.
            ESRI.ArcGIS.Display.IPictureMarkerSymbol pictureMarkerSymbol = new ESRI.ArcGIS.Display.PictureMarkerSymbolClass();
            pictureMarkerSymbol.CreateMarkerSymbolFromFile(pictureType, filename);
            pictureMarkerSymbol.Angle = 0;
            pictureMarkerSymbol.BitmapTransparencyColor = rgbColor;
            pictureMarkerSymbol.Size = markerSize;
            pictureMarkerSymbol.XOffset = 0;
            pictureMarkerSymbol.YOffset = 0;

            return pictureMarkerSymbol;
        }

        private string ScalePicture(string file,int newsize)
        {
            string output = file;
            Image img = Image.FromFile(file);
            System.Drawing.Size s = new System.Drawing.Size(newsize, newsize);
            System.Drawing.Image resizedImg = Resize(img, s, true);
            using (System.IO.MemoryStream memStream = new System.IO.MemoryStream())
            {
                if (System.Drawing.Imaging.ImageFormat.Png.Equals(img.RawFormat))
                {
                    resizedImg.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (System.Drawing.Imaging.ImageFormat.Jpeg.Equals(img.RawFormat))
                {
                    resizedImg.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (System.Drawing.Imaging.ImageFormat.Bmp.Equals(img.RawFormat))
                {
                    resizedImg.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (System.Drawing.Imaging.ImageFormat.Emf.Equals(img.RawFormat))
                {
                    resizedImg.Save(memStream, System.Drawing.Imaging.ImageFormat.Emf);
                }
                else if (System.Drawing.Imaging.ImageFormat.Gif.Equals(img.RawFormat))
                {
                    resizedImg.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif);
                }
                Image newimg = Image.FromStream(memStream);
                string tempfile = Path.GetTempFileName();
                newimg.Save(tempfile);
                output = tempfile;
            }
            return output;
        }

        new private static System.Drawing.Image  Resize(System.Drawing.Image image,
    System.Drawing.Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            System.Drawing.Image newImage = new System.Drawing.Bitmap(newWidth, newHeight);
            using (System.Drawing.Graphics graphicsHandle = System.Drawing.Graphics.FromImage(newImage))
            {
                graphicsHandle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphicsHandle.InterpolationMode =
                           System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }
    }
}