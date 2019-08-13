using System;

using System.Drawing;

using System.Windows.Forms;

namespace lab7_1
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Bitmap btm;
        private Graphics scg;
        private Timer t;

        private Animation animation;
        private int next = -1;
        private int[] xCoordinates = new int[] {100, 600, 350};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                        
            t.Interval = int.Parse(textBox1.Text) * 1000;
            t.Stop();
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            btm = new Bitmap(this.Width, this.Height);
            scg = Graphics.FromImage(btm);
            t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            animation = new Animation(new Bitmap[] { Properties.Resources.RedLight, Properties.Resources.YellowLight, Properties.Resources.GreenLight });
        }

        void t_Tick(object sender, EventArgs e)
        {
            scg.Clear(this.BackColor);
            scg.DrawImage(animation.giveNextImage(), new Point(nextX(), 50));
            g.DrawImage(btm, Point.Empty);
            
            //g.Clear(Color.Transparent);

        }

        private int nextX()
        {
            next++;
            if (next != 3)
            {                
                return xCoordinates[next];
            }
            else
            {
                next = 0;
                return xCoordinates[next];
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
