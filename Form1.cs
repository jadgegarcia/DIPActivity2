using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DIPActivity2
{
    public partial class Form1 : Form
    {
        Bitmap imageB, imageA, colorgreen;
        Device device;
        Bitmap bitcam, rescam;
        string mode;
        Color pixel;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            loadImage.Image = imageB;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            loadBackground.Image = imageA;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device = new Device();
            device.ShowWindow(loadBackground);
            timer1.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device.Stop();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image image;
            Color campix;
            if (device != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                if (data != null && data.GetDataPresent(DataFormats.Bitmap))
                {
                    image = (Image)data.GetData("System.Drawing.Bitmap", true);
                    bitcam = new Bitmap(image);
                    rescam = new Bitmap(bitcam.Width, bitcam.Height);
                    loadBackground.Image = rescam;
                }

                if (mode == "1") // normal mode
                {
                    device.Sendmessage();
                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            campix = bitcam.GetPixel(x, y);
                            rescam.SetPixel(x, y, pixel);
                        }
                    }
                    pictureBox3.Image = rescam;
                    //label6.Text = "Normal";
                }

                if (mode == "2") // greyscale mode
                {
                    device.Sendmessage();
                    int avg;
                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            campix = bitcam.GetPixel(x, y);
                            avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                            rescam.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                        }
                    }
                    pictureBox3.Image = rescam;
                    //label6.Text = "Greyscale";
                }

                if (mode == "3") // inversion mode
                {
                    device.Sendmessage();
                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            campix = bitcam.GetPixel(x, y);
                            rescam.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                        }
                    }
                    pictureBox3.Image = rescam;
                    //label6.Text = "Inversion";
                }

                if (mode == "4") // sepia mode
                {
                    device.Sendmessage();
                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            campix = bitcam.GetPixel(x, y);

                            int r = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                            int g = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                            int b = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                            if (r > 255) { r = 255; }
                            if (g > 255) { g = 255; }
                            if (b > 255) { b = 255; }

                            rescam.SetPixel(x, y, Color.FromArgb(r, g, b));
                        }
                    }
                    pictureBox3.Image = rescam;
                    //label6.Text = "Sepia";
                }

                if (mode == "5") // histogram mode
                {
                    device.Sendmessage();

                    int avg;

                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            campix = bitcam.GetPixel(x, y);
                            avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                            rescam.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                        }
                    }

                    Color histpix;
                    int[] histogram = new int[256];
                    for (int x = 0; x < bitcam.Width; x++)
                    {
                        for (int y = 0; y < bitcam.Height; y++)
                        {
                            histpix = rescam.GetPixel(x, y);
                            histogram[histpix.R]++;
                        }
                    }

                    Bitmap datas = new Bitmap(256, 379);

                    //Background
                    for (int x = 0; x < 256; x++)
                    {
                        for (int y = 0; y < 379; y++)
                        {
                            datas.SetPixel(x, y, Color.White);
                        }
                    }

                    //Histogram Data
                    for (int x = 0; x < 256; x++)
                    {
                        for (int y = 0; y < Math.Min(histogram[x] / 5, 379); y++)
                        {
                            datas.SetPixel(x, y, Color.Black);
                        }
                    }

                    pictureBox3.Image = rescam;
                    //label6.Text = "Histogram";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R +  mygreen.G + mygreen.B) / 3;
            int threshold = 5;
            Bitmap resultImage = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                        
                    } else
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                        
                }
                pictureBox3.Image = resultImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }
        

      

    }
}
