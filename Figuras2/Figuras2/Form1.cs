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

namespace Figuras2
{
    public partial class Form1 : Form
    {
        List<Figuras2> figuras;
        
        public Form1()
        {
            figuras = new List<Figuras2>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Circulo C = new Circulo(e.X, e.Y);
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figuras2 f in figuras)
            {
                f.Dibujar(this);
            }
        }
    }
}
