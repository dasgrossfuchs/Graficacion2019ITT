using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image Estrella()
        {
            Bitmap imagen = new Bitmap(300, 300);
            Graphics grafico = Graphics.FromImage(imagen);
            Pen pluma;

            grafico.DrawLine(pluma = new Pen(Color.Black, 3), 0, 150, 300, 150);
            grafico.DrawLine(pluma = new Pen(Color.Black, 3), 150, 0, 150, 300);

            for (int contador = 1; contador <= 10; contador++)
            {
                grafico.DrawLine(pluma = new Pen(Color.Green, 1), 150 + (contador * 15), 145, 150 + (contador * 15), 155);
                grafico.DrawLine(pluma = new Pen(Color.Green, 1), -15 + (contador * 15), 145, -15 + (contador * 15), 155);

                grafico.DrawLine(pluma = new Pen(Color.Green, 1), 145, -15 + (contador * 15), 155, -15 + (contador * 15));
                grafico.DrawLine(pluma = new Pen(Color.Green, 1), 145, 150 + (contador * 15), 155, 150 + (contador * 15));

                grafico.DrawLine(pluma = new Pen(Color.Blue, 1), -15 + (contador * 15), 150, 150, 150 - (contador * 15));
                grafico.DrawLine(pluma = new Pen(Color.Blue, 1), 150 - (contador * 15), 150, 150, 315 - (contador * 15));

                grafico.DrawLine(pluma = new Pen(Color.Blue, 1), 150 + (contador * 15), 150, 150, -15 + (contador * 15));
                grafico.DrawLine(pluma = new Pen(Color.Blue, 1), 150 + (contador * 15), 150, 150, 315 - (contador * 15));
            }

            return imagen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbDibujo.Width = Form1.ActiveForm.Width;
            pbDibujo.Height = Form1.ActiveForm.Height;
            pbDibujo.Image = Estrella();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbDibujo.Width = Form1.ActiveForm.Width;
            pbDibujo.Height = Form1.ActiveForm.Height;
        }

        private void pbDibujo_Click(object sender, EventArgs e)
        {

        }
    }


}
