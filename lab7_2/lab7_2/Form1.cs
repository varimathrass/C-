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

namespace lab7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String fileName = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(fileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Jpeg;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName, format);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int width = bmp.Width;
            int height = bmp.Height;
            
            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            pictureBox2.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "jpeg";
            saveFileDialog1.Filter = "Jpeg image (*.jpeg)|*.jpeg";
        }
    }
}
