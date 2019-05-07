using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GameAsset_Fondo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SolidBrush Black = new SolidBrush(Color.Black);
        SolidBrush BlueVentanas = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush A = new SolidBrush(Color.DarkViolet);
        SolidBrush LYellow = new SolidBrush(Color.LightYellow);
        SolidBrush Yellow = new SolidBrush(Color.LightGoldenrodYellow);
        SolidBrush Morado = new SolidBrush(Color.CadetBlue);
        SolidBrush ColorIglesia = new SolidBrush(Color.RosyBrown);
        SolidBrush Blanco = new SolidBrush(Color.White);
        SolidBrush ColorCualquiera = new SolidBrush(Color.BlanchedAlmond);
        SolidBrush Coral = new SolidBrush(Color.Coral);
        SolidBrush Rojo = new SolidBrush(Color.Red);
        SolidBrush ALet = new SolidBrush(Color.DarkOliveGreen);
        SolidBrush Cafe = new SolidBrush(Color.Chocolate);
        SolidBrush Blue = new SolidBrush(Color.MediumBlue);
        SolidBrush Lila = new SolidBrush(Color.Purple);
        SolidBrush Naranja = new SolidBrush(Color.Orange);
        SolidBrush Naranjados = new SolidBrush(Color.DarkOrange);
        SolidBrush AzulCielo = new SolidBrush(Color.LightSkyBlue);
        SolidBrush VVV = new SolidBrush(Color.Green);
        SolidBrush Rosa = new SolidBrush(Color.Pink);
        SolidBrush Gris = new SolidBrush(Color.Gray);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void antena_Alto(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Gris, new Rectangle(370, 390, 5, 30)); // alto
            e.Graphics.DrawLine(Pens.Red, 365, 390, 380, 390); // base abajo
            e.Graphics.DrawLine(Pens.Red, 365, 365, 380, 365);// Base arriba
            e.Graphics.DrawLine(Pens.Red, 360, 371, 360, 386); // Izqierda
            e.Graphics.DrawLine(Pens.Red, 385, 371, 385, 386); // DErecha
            e.Graphics.DrawLine(Pens.Red, 365, 365, 360, 371); // arriba izquierda
            e.Graphics.DrawLine(Pens.Red, 360, 386, 365, 390); // abajo izquierda
            e.Graphics.DrawLine(Pens.Red, 380, 365, 385, 371); // arriba derecha
            e.Graphics.DrawLine(Pens.Red, 385, 386, 380, 390); // abajo derecha
            List<Point> PP = new List<Point>();
            PP.Add(new Point(365, 365));
            PP.Add(new Point(380, 365));
            PP.Add(new Point(385, 371));
            PP.Add(new Point(385, 386));
            PP.Add(new Point(380, 390));
            PP.Add(new Point(365, 390));
            PP.Add(new Point(360, 386));
            PP.Add(new Point(360, 371));
            e.Graphics.FillPolygon(Rojo, PP.ToArray());
            Font DrawFont = new Font("Arial",5);
            e.Graphics.DrawString("ALTO", DrawFont, Blanco, 363,375);
            // Antena

        }
        public void Ultimos2E(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Blanco, new Rectangle(630, 320, 50,100));

            e.Graphics.DrawLine(Pens.Chocolate, 615, 320, 655, 300); // Linea de Izquierda hacia arriba diagonal
            e.Graphics.DrawLine(Pens.Chocolate, 655, 300, 695, 320); // Segunda diagonal hacia derecha            
            e.Graphics.DrawLine(Pens.Chocolate, 615, 320, 695, 320); // LineaBaseArriba           
            List < Point > Placata = new List<Point>();
            Placata.Add(new Point(615, 320));
            Placata.Add(new Point(655, 300));
            Placata.Add(new Point(695, 320));
            e.Graphics.FillPolygon(Cafe, Placata.ToArray());
            e.Graphics.FillRectangle(Rosa, new Rectangle(645, 380, 20, 40));
            int y = 330;
            for (int i = 0; i < 2; i++)
            {
                int x = 637;
                for (int j = 0; j < 2; j++)
                {
                    e.Graphics.FillRectangle(Rojo, new Rectangle(x,y,15,15));
                    x = x + 20;
                }
                y = y + 20;
            }
        }
        public void PUltimas4(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Lila, new Rectangle(440, 380, 120, 40)); // CAsa abajo
            e.Graphics.FillRectangle(Blanco, new Rectangle(465, 390, 20, 30));
            e.Graphics.FillRectangle(Lila, new Rectangle(430, 370, 120, 10));
            
            e.Graphics.FillRectangle(Naranjados, new Rectangle(465, 330, 90, 40)); //Casa arriba de chica
            e.Graphics.FillRectangle(AzulCielo, new Rectangle(455, 320, 100, 10));
            e.Graphics.FillRectangle(AzulCielo, new Rectangle(470, 300, 85, 20));
            e.Graphics.DrawLine(Pens.LightSkyBlue, 455, 320, 470, 300);
            List<Point> Poligono = new List<Point>();
            Poligono.Add(new Point(455, 320));
            Poligono.Add(new Point(470, 300));
            Poligono.Add(new Point(470, 320));
            e.Graphics.FillPolygon(AzulCielo, Poligono.ToArray());
            e.Graphics.FillRectangle(Naranja, new Rectangle(480, 350, 90, 70)); //CAsa alta
            int xx = 490;
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillRectangle(Blanco, new Rectangle(xx, 360, 15, 15));
                xx = xx + 20;
            }
            e.Graphics.FillRectangle(Blanco, new Rectangle(515, 390, 20, 30));
            e.Graphics.FillRectangle(Naranja, new Rectangle(470, 340, 110, 10));
            //Efrente de todos
            e.Graphics.FillRectangle(VVV, new Rectangle(510, 270, 50, 70));            
            e.Graphics.DrawLine(Pens.Chocolate, 495, 270, 535, 240); // Linea de Izquierda hacia arriba diagonal
            e.Graphics.DrawLine(Pens.Chocolate, 535, 240, 575, 270); // Segunda diagonal hacia derecha            
            e.Graphics.DrawLine(Pens.Chocolate, 510, 270, 560, 270); // LineaBaseArriba           
            e.Graphics.DrawLine(Pens.Chocolate, 510, 270, 502, 275);// linea de esquina izquierda hacia izquierda abajo          
            e.Graphics.DrawLine(Pens.Chocolate, 560, 270, 568, 275); // linea de esquina derecha derecha
            e.Graphics.DrawLine(Pens.Chocolate, 502, 275, 495, 270); // cerrado izzquierda
            e.Graphics.DrawLine(Pens.Chocolate, 575, 270, 568, 275); // cerrado derecha
            List<Point> PPP = new List<Point>();
            PPP.Add(new Point(495, 270));
            PPP.Add(new Point(535, 240));
            PPP.Add(new Point(575, 270));
            PPP.Add(new Point(568, 275));
            PPP.Add(new Point(560, 270));
            PPP.Add(new Point(510, 270));
            PPP.Add(new Point(502, 275));;
            e.Graphics.FillPolygon(Cafe, PPP.ToArray());
            int y = 280;
            for (int i = 0; i < 3; i++)
            {
                int x = 520;
                for (int j = 0; j < 2; j++)
                {
                    e.Graphics.FillRectangle(Rojo, x,y, 12, 17);
                    x = x + 20;
                }
                y = y + 20;
            }

            y = 282;
            for (int i = 0; i < 3; i++)
            {
               int x = 522;
                for (int j = 0; j < 2; j++)
                {
                    e.Graphics.FillRectangle(LYellow, x, y, 8, 12);
                    x = x + 20;
                }
                y = y + 20;
            }

        }
        public void EnfrenteIglesia(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Blue, new Rectangle(190, 380, 100, 40));
            e.Graphics.FillRectangle(Blanco, new Rectangle(190, 360, 100, 20));
            int x = 200;
            for (int i = 0; i < 5; i++)
            {
                
                e.Graphics.FillRectangle(Rojo, new Rectangle(x, 360, 10, 20));
                x = x + 20;
            }
            
            e.Graphics.FillRectangle(Black, new Rectangle(235, 390, 20, 30));

        }
        public void EdificiosOscuros(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Black, new Rectangle(0, 250, 30, 170)); // Edificio 1
            e.Graphics.FillRectangle(Black, new Rectangle(30, 310, 80, 110)); //Edificio 2
            int X = 40;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 320, 20, 30)); // ventanas
                X = X + 30;
            }
            X = 40;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 360, 20, 30)); // segundas ventanas
                X = X + 30;
            }
            e.Graphics.FillRectangle(Black, new Rectangle(110, 270, 25, 150)); //edificio 3
            X = 115;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 280, 5, 10)); // ventanas
                X = X + 10;
            }
            X = 115;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 295, 5, 10)); // ventanas
                X = X + 10;
            }
            e.Graphics.FillRectangle(Black, new Rectangle(135, 230, 25, 190)); //Edificio 4
            X = 140;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 240, 5, 10)); // ventanas
                X = X + 10;
            }
            X = 140;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 255, 5, 10)); // ventanas
                X = X + 10;
            }
            e.Graphics.FillRectangle(Black, new Rectangle(160, 200, 30, 220)); //Edificio 5
            X = 165;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 270, 5, 10)); // ventanas
                X = X + 10;
            }
            X = 165;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 285, 5, 10)); // ventanas
                X = X + 10;
            }
            e.Graphics.FillRectangle(Black, new Rectangle(470, 180, 150, 240)); //Edificio 6 bajo luna
            e.Graphics.FillRectangle(Black, new Rectangle(530, 140, 45, 170)); //Edificio 7 bajo luna
            e.Graphics.FillRectangle(Black, new Rectangle(575, 160, 45, 170)); //Edificio 8 bajo luna
            e.Graphics.FillRectangle(Black, new Rectangle(620, 200, 80, 220)); //Edificio 9
            X = 630;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 210, 20, 30)); // ventanas
                X = X + 30;
            }
            X = 630;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 250, 20, 30)); // segundas ventanas
                X = X + 30;
            }
            X = 630;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 290, 20, 30)); // terceras ventanas
                X = X + 30;
            }
        }
        public void Iglesia(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(ColorIglesia, new Rectangle(205, 208, 20, 5)); // Cruz
            e.Graphics.FillRectangle(ColorIglesia, new Rectangle(213, 201, 5, 20));
            e.Graphics.FillEllipse(ColorIglesia, new Rectangle(190,220, 50, 50)); // Arriba
            e.Graphics.FillRectangle(ColorIglesia, new Rectangle(190, 245, 50, 175)); // Ellipse
            e.Graphics.FillRectangle(Blanco, new Rectangle(190, 245, 50, 5));           
            int y = 255;
            for (int j = 0; j < 2; j++)
            {
                int x = 195;
                for (int i = 0; i < 3; i++)
                {
                    e.Graphics.FillEllipse(Blanco, new Rectangle(x, y, 10, 20));
                    x = x + 15;
                }
                y = y + 23;
            }          
            e.Graphics.FillRectangle(Blanco, new Rectangle(190, 300, 50, 5));
            y = 310;
            for (int j = 0; j < 2; j++)
            {
                int x = 195;
                for (int i = 0; i < 3; i++)
                {
                    e.Graphics.FillEllipse(Blanco, new Rectangle(x, y, 10, 20));
                    x = x + 15;
                }
                y = y + 23;
            }
           
            y = 365;
            for (int j = 0; j < 2; j++)
            {
                int x = 195;
                for (int i = 0; i < 3; i++)
                {
                    e.Graphics.FillEllipse(Blanco, new Rectangle(x, y, 10, 20));
                    x = x + 15;
                }
                y = y + 23;
            }

        }
        public void Casita1_Y_Atras(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(ColorCualquiera, new Rectangle(90, 390, 100, 30));
            e.Graphics.DrawLine(Pens.Coral, 85, 390, 200, 390); // linea abajo
            e.Graphics.DrawLine(Pens.Coral, 90, 360, 190, 360); // linea arriba
            e.Graphics.DrawLine(Pens.Coral, 85, 390, 90, 360); // linea izquierda
            e.Graphics.DrawLine(Pens.Coral, 200, 390, 190, 360); // linea derecha
            List<Point> Puntos = new List<Point>();
            Puntos.Add(new Point(85,390));
            Puntos.Add(new Point(200, 390));
            Puntos.Add(new Point(190, 360));
            Puntos.Add(new Point(90, 360));
            e.Graphics.FillPolygon(Coral, Puntos.ToArray());
            e.Graphics.FillRectangle(Rojo, 120, 330, 50, 90); // CasitaRoja
            e.Graphics.DrawLine(Pens.Chocolate, 105, 330, 145, 300); // Linea de Izquierda hacia arriba diagonal
            e.Graphics.DrawLine(Pens.Chocolate, 145, 300, 185, 330); // Segunda diagonal hacia derecha
            e.Graphics.DrawLine(Pens.Chocolate, 120, 330, 170, 330); // LineaBaseArriba
            e.Graphics.DrawLine(Pens.Chocolate, 120, 330, 112, 335);// linea de esquina izquierda hacia izquierda abajo
            e.Graphics.DrawLine(Pens.Chocolate, 112, 335, 105, 330); // cerrado de izquierda
            e.Graphics.DrawLine(Pens.Chocolate, 170, 330, 178, 335); // linea de esquina derecha derecha
            e.Graphics.DrawLine(Pens.Chocolate, 178, 335, 185, 330); // Cerrado derecha
            List<Point> PPP = new List<Point>();
            PPP.Add(new Point(145, 300));
            PPP.Add(new Point(185, 330));
            PPP.Add(new Point(178, 335));
            PPP.Add(new Point(170, 330));
            PPP.Add(new Point(120, 330));
            PPP.Add(new Point(112, 335));
            PPP.Add(new Point(105, 330));
            e.Graphics.FillPolygon(Cafe, PPP.ToArray());
            int y = 337;
            for (int i = 0; i < 3; i++)
            {
                int x = 127;
                for (int j = 0; j < 2; j++)
                {
                    e.Graphics.FillRectangle(Morado, new Rectangle(x, y, 15, 15));
                    x = x + 20;
                }
                y = y + 20;
            }
            //
             y = 340;
            for (int i = 0; i < 3; i++)
            {
                int x = 130;
                for (int j = 0; j < 2; j++)
                {
                    e.Graphics.FillRectangle(LYellow, new Rectangle(x, y, 10, 10));
                    x = x + 20;
                }
                y = y + 20;
            }
            

            // SIGUEN VENTANAS

        }
        public void Edificios(object sender, PaintEventArgs e)
        {
            // Edificio Morado
            e.Graphics.FillRectangle(A, new Rectangle(740, 200, 100, 220));
            int Y = 210;
            for (int i = 0; i < 11; i++)
            {
                e.Graphics.FillRectangle(Yellow, new Rectangle(750, Y, 80, 10));
                Y =Y+20;
            }
            //Derecha Morado       
            e.Graphics.FillRectangle(Black, new Rectangle(840, 310, 150, 110));
            int X = 860;
                for (int i = 0; i < 2; i++)
                {

                    e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 320, 20, 30));
                    X = X + 30;
                }
            X = 860;
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.FillRectangle(BlueVentanas, new Rectangle(X, 360, 20, 30));
                X = X + 30;
            }
            //EDificio Blue Cadet
            e.Graphics.FillRectangle(Morado, new Rectangle(350, 240, 110, 180));
            X = 365;
            for (int i = 0; i < 3; i++)
            {

                e.Graphics.FillRectangle(Yellow, new Rectangle(X, 250, 20, 30)); // ventanas
                X = X + 30;
            }
            X = 365;
            for (int i = 0; i < 3; i++)
            {

                e.Graphics.FillRectangle(Yellow, new Rectangle(X, 290, 20, 30)); // segundas ventanas
                X = X + 30;
            }
            X = 365;
            for (int i = 0; i < 3; i++)
            {

                e.Graphics.FillRectangle(Yellow, new Rectangle(X, 330, 20, 30)); // segundas ventanas
                X = X + 30;
            }
            X = 365;
            for (int i = 0; i < 3; i++)
            {

                e.Graphics.FillRectangle(Yellow, new Rectangle(X, 370, 20, 30)); // segundas ventanas
                X = X + 30;
            }



        }
            public void Arboles(object sender, PaintEventArgs e)
        {
            SolidBrush Cafe = new SolidBrush(Color.SandyBrown);
            SolidBrush Verde = new SolidBrush(Color.ForestGreen);
            e.Graphics.FillRectangle(Cafe, new Rectangle(290, 380, 10, 40));
            e.Graphics.FillRectangle(Cafe, new Rectangle(600, 380, 10, 40));
            e.Graphics.FillRectangle(Cafe, new Rectangle(720, 380, 10, 40));
            e.Graphics.FillEllipse(Verde, 275, 340, 40, 40);
            e.Graphics.FillEllipse(Verde, 585, 340, 40, 40);
            e.Graphics.FillEllipse(Verde, 705, 340, 40, 40);
        }
        public void Estrellas(object sender, PaintEventArgs e)
        {
            int x = 45;
            int y = 19;
            Random Rx = new Random();
            Random Ry = new Random();
            for (int i = 0; i < 40; i++)
            {
                x = Rx.Next(0, 950);
                y = Rx.Next(0, 260);
                e.Graphics.FillEllipse(Blanco, x, y, 2, 2);
            }
            e.Graphics.FillEllipse(Blanco, 390, 30, 150, 150);
        }
        public void Calle(object sender, PaintEventArgs e)
        {
            SolidBrush Gris = new SolidBrush(Color.DarkGray);
            SolidBrush Blue = new SolidBrush(Color.SteelBlue);
            SolidBrush Blanco = new SolidBrush(Color.White);
            Graphics formGraphics = CreateGraphics();
            e.Graphics.FillRectangle(Gris, 0, 440, 950, 500);
            e.Graphics.FillRectangle(Blue, 0, 420, 950, 20);
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                e.Graphics.FillRectangle(Blanco, c, 460, 65, 10);
                c = c +100;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            Image Imagen = pictureBox2.Image;
            Guardar.ShowDialog();
            Imagen.Save(Guardar.FileName);
        }

        private void pictureBox2_Paint_1(object sender, PaintEventArgs e)
        {
            
            Bitmap bit = new Bitmap(pictureBox2.Width,pictureBox2.Height); // Convierte la imagen 
            Graphics G = Graphics.FromImage(bit);
            Calle(sender, e);
            Estrellas(sender, e);
            
            EdificiosOscuros(sender, e);
            Iglesia(sender, e);
            EnfrenteIglesia(sender, e);
            Edificios(sender, e);
            Casita1_Y_Atras(sender, e);
            Ultimos2E(sender, e);
            PUltimas4(sender, e);
            Arboles(sender, e);
            antena_Alto(sender, e);
            pictureBox2.Image = bit;
            pictureBox2.DrawToBitmap(bit, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bit, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            Image Imagen = pictureBox2.Image;
            Guardar.ShowDialog();
            bit.Save(Guardar.FileName);
        }
    }
}
