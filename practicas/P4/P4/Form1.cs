using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardado = new SaveFileDialog();
            guardado.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files(*.jpg)|*jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";
            guardado.FilterIndex = 5;
            guardado.RestoreDirectory = true;
            if (guardado.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image.Save(guardado.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Image bmp = pictureBox1.Image;

            Graphics gc = Graphics.FromImage(bmp);

            Pen Yell = new Pen(Color.BlueViolet);
            Pen Mag = new Pen(Color.Magenta);
            Pen Blue = new Pen(Color.Blue);
            Pen Red = new Pen(Color.Red);
            Pen Blk = new Pen(Color.Black, 2);
            //referencia centro 500,220
            //eje x
            gc.DrawLine(Blk, 0, 110, 220, 110);
            //eje y
            gc.DrawLine(Blk, 110, 0, 110, 220);
            //cuadrante ++
            for (int i = 0; i < 10; i++)
            {
                gc.DrawLine(Mag, 220 - (i * 10), 110, 110, 100 - (i * 10));
                gc.DrawLine(Blue, 220 - (i * 10), 110, 110, 120 + (i * 10));
                gc.DrawLine(Red, 0 + (i * 10), 110, 110, 120 + (i * 10));
                gc.DrawLine(Yell, 0 + (i * 10), 110, 110, 100 - (i * 10));
            }
        }
    }
}
