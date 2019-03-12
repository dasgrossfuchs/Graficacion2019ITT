using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gc = CreateGraphics();

            Pen Yell = new Pen(Color.BlueViolet);
            Pen Mag = new Pen(Color.Magenta);
            Pen Blue = new Pen(Color.Blue);
            Pen Red = new Pen(Color.Red);
            Pen Blk = new Pen(Color.Black, 2);
            //referencia centro 500,220
            //eje x
            gc.DrawLine(Blk, 280, 220, 720, 220);
            //eje y
            gc.DrawLine(Blk, 500, 0, 500, 440);
            //cuadrante ++
            for (int i = 0; i < 10; i++)
            {
                gc.DrawLine(Mag, 720-(i*20), 220, 500, 200-(i*20));
                gc.DrawLine(Blue, 720-(i*20), 220, 500, 240+(i*20));
                gc.DrawLine(Red, 280+(i*20), 220, 500, 240+(i*20));
                gc.DrawLine(Yell, 280+(i*20), 220, 500, 200-(i*20));
            }
            //gc.DrawLine(Mag, 720, 220, 500, 200);
            //gc.DrawLine(Mag, 700, 220, 500, 180);
            //gc.DrawLine(Mag, 680, 220, 500, 160);
            //gc.DrawLine(Mag, 660, 220, 500, 140);
            //gc.DrawLine(Mag, 640, 220, 500, 120);
            //gc.DrawLine(Mag, 620, 220, 500, 100);
            //gc.DrawLine(Mag, 600, 220, 500, 80);
            //gc.DrawLine(Mag, 580, 220, 500, 60);
            //gc.DrawLine(Mag, 560, 220, 500, 40);
            //gc.DrawLine(Mag, 540, 220, 500, 20);
            //gc.DrawLine(Mag, 520, 220, 500, 0);
            ////cuadrante +-
            //gc.DrawLine(Blue, 720, 220, 500, 240);
            //gc.DrawLine(Blue, 700, 220, 500, 260);
            //gc.DrawLine(Blue, 680, 220, 500, 280);
            //gc.DrawLine(Blue, 660, 220, 500, 300);
            //gc.DrawLine(Blue, 640, 220, 500, 320);
            //gc.DrawLine(Blue, 620, 220, 500, 340);
            //gc.DrawLine(Blue, 600, 220, 500, 360);
            //gc.DrawLine(Blue, 580, 220, 500, 380);
            //gc.DrawLine(Blue, 560, 220, 500, 400);
            //gc.DrawLine(Blue, 540, 220, 500, 420);
            //gc.DrawLine(Blue, 520, 220, 500, 440);
            ////cuadrante --
            //gc.DrawLine(Red, 280, 220, 500, 240);
            //gc.DrawLine(Red, 300, 220, 500, 260);
            //gc.DrawLine(Red, 320, 220, 500, 280);
            //gc.DrawLine(Red, 340, 220, 500, 300);
            //gc.DrawLine(Red, 360, 220, 500, 320);
            //gc.DrawLine(Red, 380, 220, 500, 340);
            //gc.DrawLine(Red, 400, 220, 500, 360);
            //gc.DrawLine(Red, 420, 220, 500, 380);
            //gc.DrawLine(Red, 440, 220, 500, 400);
            //gc.DrawLine(Red, 460, 220, 500, 420);
            //gc.DrawLine(Red, 480, 220, 500, 440);
            ////cuadrante -+
            //gc.DrawLine(Yell, 280, 220, 500, 200);
            //gc.DrawLine(Yell, 300, 220, 500, 180);
            //gc.DrawLine(Yell, 320, 220, 500, 160);
            //gc.DrawLine(Yell, 340, 220, 500, 140);
            //gc.DrawLine(Yell, 360, 220, 500, 120);
            //gc.DrawLine(Yell, 380, 220, 500, 100);
            //gc.DrawLine(Yell, 400, 220, 500, 80);
            //gc.DrawLine(Yell, 420, 220, 500, 60);
            //gc.DrawLine(Yell, 440, 220, 500, 40);
            //gc.DrawLine(Yell, 460, 220, 500, 20);
            //gc.DrawLine(Yell, 480, 220, 500, 0);
        }
    }
}
