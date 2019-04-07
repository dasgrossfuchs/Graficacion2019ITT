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
        bool right = true;
        Image img = Image.FromFile(@"vita.png");
        Rectangle idle1 = new Rectangle(4, 3, 15, 18);
        Rectangle idle2 = new Rectangle(28, 3, 15, 18);
        Rectangle idle3 = new Rectangle(52, 3, 15, 18);
        Rectangle idle4 = new Rectangle(76, 3, 15, 18);
        Rectangle run1 = new Rectangle(100, 3, 15, 18);
        Rectangle run2 = new Rectangle(124, 3, 15, 18);
        Rectangle run3 = new Rectangle(148, 3, 15, 18);
        Rectangle run4 = new Rectangle(172, 3, 15, 18);
        Rectangle run5 = new Rectangle(196, 3, 15, 18);
        Rectangle run6 = new Rectangle(220, 3, 15, 18);
        Rectangle atk1 = new Rectangle(244, 3, 15, 18);
        Rectangle atk2 = new Rectangle(266, 3, 15, 18);
        Rectangle atk3 = new Rectangle(292, 3, 15, 18);
        Rectangle oof1 = new Rectangle(316, 3, 15, 18);
        Rectangle oof2 = new Rectangle(340, 3, 15, 18);
        Rectangle oof3 = new Rectangle(364, 3, 15, 18);
        Rectangle oof4 = new Rectangle(388, 3, 15, 18);
        Rectangle crun1 = new Rectangle(412, 3, 15, 18);
        Rectangle crun2 = new Rectangle(436, 3, 15, 18);
        Rectangle crun3 = new Rectangle(460, 3, 15, 18);
        Rectangle crun4 = new Rectangle(484, 3, 15, 18);
        Rectangle crun5 = new Rectangle(508, 3, 15, 18);
        Rectangle crun6 = new Rectangle(532, 3, 15, 18);
        Rectangle crun7 = new Rectangle(556, 3, 15, 18);

        //left
        Rectangle lcrun7 = new Rectangle(4, 3, 15, 18);
        Rectangle lcrun6 = new Rectangle(28, 3, 15, 18);
        Rectangle lcrun5 = new Rectangle(52, 3, 15, 18);
        Rectangle lcrun4 = new Rectangle(76, 3, 15, 18);
        Rectangle lcrun3 = new Rectangle(100, 3, 15, 18);
        Rectangle lcrun2 = new Rectangle(124, 3, 15, 18);
        Rectangle lcrun1 = new Rectangle(148, 3, 15, 18);
        Rectangle loof4 = new Rectangle(172, 3, 15, 18);
        Rectangle loof3 = new Rectangle(196, 3, 15, 18);
        Rectangle loof2 = new Rectangle(220, 3, 15, 18);
        Rectangle loof1 = new Rectangle(244, 3, 15, 18);
        Rectangle latk3 = new Rectangle(266, 3, 15, 18);
        Rectangle latk2 = new Rectangle(292, 3, 15, 18);
        Rectangle latk1 = new Rectangle(316, 3, 15, 18);
        Rectangle lrun6 = new Rectangle(340, 3, 15, 18);
        Rectangle lrun5 = new Rectangle(364, 3, 15, 18);
        Rectangle lrun4 = new Rectangle(388, 3, 15, 18);
        Rectangle lrun3 = new Rectangle(412, 3, 15, 18);
        Rectangle lrun2 = new Rectangle(436, 3, 15, 18);
        Rectangle lrun1 = new Rectangle(460, 3, 15, 18);
        Rectangle lidle4 = new Rectangle(484, 3, 15, 18);
        Rectangle lidle3 = new Rectangle(508, 3, 15, 18);
        Rectangle lidle2 = new Rectangle(532, 3, 15, 18);
        Rectangle lidle1 = new Rectangle(556, 3, 15, 18);

        bool stk = false;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Threading.Thread.Sleep(1000);
            pictureBox1.Image = cropImage(img, idle1);
            pictureBox1.Refresh();

            button1.Hide();
            button2.Hide();

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
        public void run()
        {
            
            int sleep = 50;
            
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run1);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run2);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run3);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run4);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run5);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run6);
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(sleep);
                pictureBox1.Image = cropImage(img, run1);
                pictureBox1.Refresh();
        }
        public void lrun()
        {

            int sleep = 50;

            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun1);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun2);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun3);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun4);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun5);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun6);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Image = cropImage(img, lrun1);
            pictureBox1.Refresh();

        }
        public void jump()
        {
            int sleep = 100;
            
            Point start = new Point(pictureBox1.Location.X,pictureBox1.Location.Y);
            System.Threading.Thread.Sleep(sleep);


            pictureBox1.Image = cropImage(img, atk1);
            pictureBox1.Refresh();
            pictureBox1.Location = new Point(start.X,start.Y);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X+3*5, start.Y-5 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X+7 * 5, start.Y-10 * 5);
            System.Threading.Thread.Sleep(sleep);


            
            pictureBox1.Image = cropImage(img, atk2);
            pictureBox1.Refresh();


            pictureBox1.Location = new Point(start.X+10 * 5, start.Y-12 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 14 * 5, start.Y - 14 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 17 * 5, start.Y - 15 * 5);
            System.Threading.Thread.Sleep(sleep);


            
            pictureBox1.Image = cropImage(img, atk3);
            pictureBox1.Refresh();

            pictureBox1.Location = new Point(start.X + 21 * 5, start.Y - 16 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 25 * 5, start.Y - 17 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 29 * 5, start.Y - 18 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X+33 * 5, start.Y-19* 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 37 * 5, start.Y - 20 * 5);
            System.Threading.Thread.Sleep(sleep);

            pictureBox1.Location = new Point(start.X + 41 * 5, start.Y - 20 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 45 * 5, start.Y - 19 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 49 * 5, start.Y - 18 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 53 * 5, start.Y - 17 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 57 * 5, start.Y - 17 * 5);
            System.Threading.Thread.Sleep(sleep);




            pictureBox1.Image = cropImage(img, atk2);
            pictureBox1.Refresh();

            pictureBox1.Location = new Point(start.X + 61 * 5, start.Y - 15 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 64 * 5, start.Y - 14 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 68 * 5, start.Y - 12 * 5);
            System.Threading.Thread.Sleep(sleep);
            

            pictureBox1.Image = cropImage(img, atk1);
            pictureBox1.Refresh();

            pictureBox1.Location = new Point(start.X + 70 * 5, start.Y - 10 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 72 * 5, start.Y - 5 * 5);
            System.Threading.Thread.Sleep(sleep);
            pictureBox1.Location = new Point(start.X + 74 * 5, start.Y );
            System.Threading.Thread.Sleep(sleep);

        }

        




        private void button1_Click(object sender, EventArgs e)
        {
                run();
        }
        public int x = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            jump();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
                case Keys.Left:
                    if (right)
                    {
                        right = false;
                        img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    lrun();
                    break;
                case Keys.Right:
                    if (!right)
                    {
                        right = true;
                        img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    run();

                    break;
                case Keys.Up:
                    break;
                
                case Keys.Down:
                    break;
                default:break;
                    
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            
        }
    }
}
