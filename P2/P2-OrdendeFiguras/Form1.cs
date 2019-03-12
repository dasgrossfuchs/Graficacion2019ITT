using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_OrdendeFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dc = this.CreateGraphics();
            Pen Red = new Pen(Color.Red, 2);
            

            //trabajo
            Red.Color = Color.Purple;
            dc.DrawLine(Red, 280, 30, 280, 330);//y
            Red.Color = Color.Yellow;
            dc.DrawLine(Red, 130, 180, 430, 180);//x
            Red.Color = Color.Orange;
            dc.DrawRectangle(Red, 180, 80, 200, 200);
            Red.Color = Color.Blue;
            dc.DrawEllipse(Red, 180, 80, 200, 200);
        }
    }
}
