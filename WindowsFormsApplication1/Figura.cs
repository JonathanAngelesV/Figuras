using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Angeles Valadez Jonathan

namespace WindowsFormsApplication1
{
    abstract class Figura
    {
        public int X, Y;
        public Pen pluma;
        public Brush brocha;
        public int ancho, largo;
        public Figura(int x, int y)
        {
            X = x;
            Y = y;
            pluma = new Pen(Color.Green, 3);
            ancho = 55;
            largo = 55;
        }

        public abstract void Dibujar(Form f);



    }
    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y) : base(x, y)
        {

        }
        public override void Dibujar(Form f)
        {
            
            {
                Graphics g = f.CreateGraphics();
                g.DrawRectangle(pluma, X, Y, ancho, largo);
            }
        }
        

    }
    class Circulo : Figura
    {
        public Circulo(int x, int y) : base(x, y)
        {

        }
        public override void Dibujar(Form f)
        {

            {
                Graphics g = f.CreateGraphics();
                g.DrawEllipse(pluma, X, Y, ancho, largo);
            }
        }


    }





}
