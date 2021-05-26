//Diomedes Alexander Vallejo Perez
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Visual : Form
    { string Sonido;
        int estado = 1;
        public Visual(string sonido)
        {
            InitializeComponent();
            Sonido = sonido;
        }

        private void Visual_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Add fuenteDeSonido = new Add(false);
            fuenteDeSonido.Sonido(Sonido, estado);
            if (estado == 1)
            {
                estado = 0;
            }
            else
            {
                estado = 1;
            }
        }
    }
}
