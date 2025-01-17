using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;  //input image
        public Bitmap image;       //output image
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhis1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileImage.Filter = "bitmap (*.bmp)|*.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image = (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            image = new Bitmap(f_image.Width, f_image.Height);

            // Loop through the images pixels
            
             for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    image.SetPixel(i, j, Color.FromArgb(C_gray, C_gray, C_gray));

                }
            }
            
            pictureBox1.Image = f_image;
            pictureBox2.Image = image;
            UpdateHistograms();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThreshold_Click(object sender, EventArgs e)
        {
            { 
                int k = 30;

                Bitmap originalImage = f_image;
                Bitmap thresholdedImage = new Bitmap(originalImage.Width, originalImage.Height);

                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                   
                        Color pixelColor = originalImage.GetPixel(x, y);
                        int intensity = pixelColor.R;  //(ข้อมูลที่หามา)ใช้ R เพราะเนื่องจากภาพเป็นขาวดำ ค่าของ R, G, และ B จะเหมือนกันทุกค่า ดังนั้นเราจึงสามารถใช้ค่า R (ซึ่งเป็นค่าความเข้มของพิกเซล) เพื่อใช้ในการเปรียบเทียบ threshold       
                        Color newColor;
                        if (intensity < k)
                        {
                            newColor = Color.FromArgb(0, 0, 0); // Black for intensity < k
                        }
                        else
                        {
                            newColor = Color.FromArgb(255, 255, 255); // White for intensity >= k
                        }

                        //set px ใหม่ ในภาพที่ทำ thresholded แล้ว
                        thresholdedImage.SetPixel(x, y, newColor);
                        image = thresholdedImage;
                    }
                }
                pictureBox2.Image = image;
                UpdateHistograms();
            }

            /* =====<ChatGPT Code>===== */
            /*
            int totalGray = 0;
            int pixelCount = f_image.Width * f_image.Height;

            // Calculate Mean Gray Level
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color pixelColor = f_image.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    totalGray += gray;
                }
            }
            int meanGray = totalGray / pixelCount;

            // Apply Thresholding
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color pixelColor = f_image.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int thresholdGray = gray >= meanGray ? 255 : 0;
                    image.SetPixel(i, j, Color.FromArgb(thresholdGray, thresholdGray, thresholdGray));
                }
            }
            pictureBox2.Image = image;
            */
        }

        private void btndiffer_Click(object sender, EventArgs e)
        {
            Bitmap display_image = image;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color ori_image = f_image.GetPixel(i, j);
                    Color output_image = image.GetPixel(i, j);
                    int diff_R, diff_G, diff_B;

                    diff_R = ori_image.R - output_image.R;
                    if (diff_R < 0)
                    {
                        diff_R *= -1;
                    }
                    diff_G = ori_image.G - output_image.G;
                    if (diff_G < 0)
                    {
                        diff_G *= -1;
                    }
                    diff_B = ori_image.B - output_image.B;
                    if (diff_B < 0)
                    {
                        diff_B *= -1;
                    }
                    display_image.SetPixel(i, j, Color.FromArgb(diff_R, diff_G, diff_B));
                }
                pictureBox3.Image = display_image;
                /*=====<ChatGPT Code>=====*/
                /*
                for (int i = 0; i < f_image.Width; i++)
                {
                    for (int j = 0; j < f_image.Height; j++)
                    {
                        Color origPixel = f_image.GetPixel(i, j);
                        Color processedPixel = image.GetPixel(i, j);
                        int diffR = Math.Abs(origPixel.R - processedPixel.R);
                        int diffG = Math.Abs(origPixel.G - processedPixel.G);
                        int diffB = Math.Abs(origPixel.B - processedPixel.B);
                        image.SetPixel(i, j, Color.FromArgb(diffR, diffG, diffB));
                    }
                }
                pictureBox3.Image = image;
                */
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private Bitmap CreateHistogramBitmap(Bitmap bitmap)
        {
            int[] histogram = new int[256];
            int width = 256;
            int height = 100;

            // คำนวณค่า Histogram ของภาพ
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    histogram[gray]++;
                }
            }

            int max = histogram.Max();
            Bitmap histogramImage = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(histogramImage))
            {
                g.Clear(Color.White);
                for (int i = 0; i < histogram.Length; i++)
                {
                    int barHeight = (int)((histogram[i] / (float)max) * height);
                    g.DrawLine(Pens.Black, i, height, i, height - barHeight);
                }
            }

            return histogramImage;
        }

        private Bitmap PerformHistogramEqualization(Bitmap bitmap)
        {
            // Step 1: คำนวณ Histogram ของภาพ
            int[] histogram = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    histogram[gray]++;
                }
            }

            // Step 2: คำนวณ CDF (Cumulative Distribution Function)
            int totalPixels = bitmap.Width * bitmap.Height;
            int[] cdf = new int[256];
            cdf[0] = histogram[0];

            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i];
            }

            // Step 3: Normalize CDF
            int[] equalizedHistogram = new int[256];
            for (int i = 0; i < 256; i++)
            {
                equalizedHistogram[i] = (int)((cdf[i] - cdf[0]) * 255.0 / (totalPixels - cdf[0]));
            }

            // Step 4: Apply equalized values to each pixel in the image
            Bitmap equalizedBitmap = new Bitmap(bitmap);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int newGray = equalizedHistogram[gray];

                    Color newColor = Color.FromArgb(newGray, newGray, newGray);
                    equalizedBitmap.SetPixel(i, j, newColor);
                }
            }

            return equalizedBitmap;
        }

        private void btnhis_Click(object sender, EventArgs e)
        {
            if (f_image != null)
            {
                // แสดงกราฟ Histogram ของภาพต้นฉบับที่ pictureBox4
                pictureBox4.Image = CreateHistogramBitmap(f_image);
                UpdateHistograms();
            }
            else
            {
                MessageBox.Show("No original image loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (image != null)
            {
                // แสดงกราฟ Histogram ของภาพที่ผ่านการ Equalization ที่ pictureBox5
                pictureBox5.Image = CreateHistogramBitmap(image);

                // แสดงภาพที่ผ่านการ Histogram Equalization ที่ pictureBox2
                Bitmap equalizedImage = PerformHistogramEqualization(image);
                pictureBox2.Image = equalizedImage;
                UpdateHistograms();
            }
            else
            {
                MessageBox.Show("No processed image available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void QuantizeImage(int levels)
        {
            
            int interval = 256 / levels;

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color pixelColor = f_image.GetPixel(i, j);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                   
                    int quantizedGray = (gray / interval) * interval + interval / 2;
                    image.SetPixel(i, j, Color.FromArgb(quantizedGray, quantizedGray, quantizedGray));
                }
            }

            pictureBox2.Image = image;
            UpdateHistograms();
        }
        private void btnquan_Click(object sender, EventArgs e)
        {
            QuantizeImage(8);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            QuantizeImage(16);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Bitmap flippedImage = new Bitmap(f_image.Width, f_image.Height);

            
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    
                    Color originalPixel = f_image.GetPixel(i, j);

                    
                    flippedImage.SetPixel(f_image.Width - 1 - i, j, originalPixel);
                }
            }

            
            pictureBox2.Image = flippedImage;
            UpdateHistograms();
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            
            Bitmap flippedImage = new Bitmap(f_image.Width, f_image.Height);

            
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    
                    Color originalPixel = f_image.GetPixel(i, j);

                    // Set the pixel color in the flipped image at the vertical mirrored position
                    flippedImage.SetPixel(i, f_image.Height - 1 - j, originalPixel);
                }
            }

            
            pictureBox2.Image = flippedImage;
            UpdateHistograms();
        }
        private void UpdateHistograms()
        {
            if (f_image != null)
            {
                pictureBox4.Image = CreateHistogramBitmap(f_image);
            }

            if (image != null)
            {
                pictureBox5.Image = CreateHistogramBitmap(image);
            }
        }

    }
}
