using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Angeles Valadez Jonathan

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Figura> figuras;
        public Form1()
        {
            figuras = new List<Figura>();
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button ==  MouseButtons.Left)
            {
                Circulo C= new Circulo(e.X, e.Y);
                C.Dibujar(this);
                figuras.Add(C);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Rectangulo R = new Rectangulo(e.X, e.Y);
                R.Dibujar(this);
                figuras.Add(R);
            }
        }
    }
}
