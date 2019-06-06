using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics x = CreateGraphics();
            // Create a new pen.
            Pen skyBluePen = new Pen(Brushes.Blue);

            // Set the pen's width.
            skyBluePen.Width = 3.0F;

            // Set the LineJoin property.
            skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;

            x.DrawLine(skyBluePen, 100, 100, 215, 215);

            x.DrawRectangle(skyBluePen,250,250,50,50);
            
            x.DrawEllipse(skyBluePen, 200, 200, 100, 100);


            //Dispose of the pen.
            skyBluePen.Dispose();
        }
    }
}
