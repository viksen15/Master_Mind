using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Niveles : Form
    {
        public int nivel = 0;
        public Niveles()
        {
            InitializeComponent();
        }
        // CERRAMOS EL FORMULARIO AL CERRAR VENTANA
        private void Niveles_FormClosing(object sender, EventArgs e)
        {
            this.Close();
        }
        // CARGAMOS EL MODO PRINCIPIANTE AL PULSASR CANCELAR
        private void cancelar_Click(object sender, EventArgs e)
        {
            nivel = 0;
            this.Close();
        }
        // CARGAMOS EL NIVEL DE JUEGO DESEADO AL PULSAR ACEPTAR
        private void aceptar_Click(object sender, EventArgs e)
        {
            if (principianteB.Checked)
            {
                nivel = 0;
                this.Close();
            }
            if (medioB.Checked)
            {
                nivel = 1;
                this.Close();
            }
            if (avanzadoB.Checked)
            {
                nivel = 2;
                this.Close();
            }
        }

    }
}
