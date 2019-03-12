using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficacion
{
    public partial class Form1 : Form
    {
        bool ismousedown = false;
        Point centro = new Point(0,0);
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files(*.gif) | *.gif | All files(*.*) | *.* ";
            save.FilterIndex = 4;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            centro = e.Location;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Image bmp = pictureBox1.Image;
            Graphics g = Graphics.FromImage(bmp);
            if (ismousedown == true)
            {
                

                Pen blue = new Pen(Color.Blue, 3);
                Pen red = new Pen(Color.Red, .5f);

                for (int i = 0; i <110; i +=10)
                {
                    red.Color = Color.Salmon;
                    g.DrawLine(red, centro.X-100 + i  , centro.Y  , centro.X  , centro.Y - i);
                    red.Color = Color.LightBlue;
                    g.DrawLine(red, centro.X, centro.Y-100 + i    , centro.X + i   , centro.Y);
                    red.Color = Color.Orange;
                    g.DrawLine(red, centro.X+100 - i , centro.Y  , centro.X  , centro.Y + i);
                    red.Color = Color.PowderBlue;
                    g.DrawLine(red, centro.X, centro.Y+100 - i   , centro.X - i  , centro.Y);
                }
                g.DrawLine(blue, centro.X - 100, centro.Y, centro.X + 100, centro.Y);
                g.DrawLine(blue, centro.X, centro.Y-100, centro.X, centro.Y+100);
                

            }
            Refresh();
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
