using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafix
{
    public partial class Form1 : Form
    {
        bool stk = false;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Image img = Image.FromFile(@"vita.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //Rectangle run1 =new Rectangle(100,3,15,18);
            //Rectangle run2 = new Rectangle(124, 3, 15, 18);
            //Rectangle run3 = new Rectangle(148, 3, 15, 18);
            //Rectangle run4 = new Rectangle(172, 3, 15, 18);
            //Rectangle run5 = new Rectangle(196, 3, 15, 18);
            //Rectangle run6 = new Rectangle(220, 3, 15, 18);
            //Rectangle run7 = new Rectangle(244, 3, 15, 18);
            


            //pictureBox1.Image = cropImage(img, run1);
            Timer timer = new Timer();
            
            
            timer.Interval = (1 * 1000); // 1000 = 1 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            

        }
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            //refresh here...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"vita.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Rectangle run1 = new Rectangle(100, 3, 15, 18);
            Rectangle run2 = new Rectangle(124, 3, 15, 18);
            Rectangle run3 = new Rectangle(148, 3, 15, 18);
            Rectangle run4 = new Rectangle(172, 3, 15, 18);
            Rectangle run5 = new Rectangle(196, 3, 15, 18);
            Rectangle run6 = new Rectangle(220, 3, 15, 18);
            Rectangle run7 = new Rectangle(244, 3, 15, 18);



            pictureBox1.Image = cropImage(img, run1);
            while (true)
            {
                System.Threading.Thread.Sleep(500);

                count++;

                switch (count)
                {
                    case 1:
                        pictureBox1.Image = cropImage(img, run1);
                        pictureBox1.Refresh();
                        break;
                    case 2:
                        pictureBox1.Image = cropImage(img, run2);
                        pictureBox1.Refresh();
                        break;
                    case 3:
                        pictureBox1.Image = cropImage(img, run3);
                        pictureBox1.Refresh();
                        break;
                    case 4:
                        pictureBox1.Image = cropImage(img, run4);
                        pictureBox1.Refresh();
                        break;
                    case 5:
                        pictureBox1.Image = cropImage(img, run5);
                        pictureBox1.Refresh();
                        break;
                    case 6:
                        pictureBox1.Image = cropImage(img, run6);
                        pictureBox1.Refresh();
                        break;
                    case 7:
                        pictureBox1.Image = cropImage(img, run7);
                        pictureBox1.Refresh();
                        break;


                    default:
                        break;
                }


                if (count == 7)
                { count = 0; }
            }
        }
    }
}
