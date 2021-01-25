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
        Principal modo = new Principal();
        public Niveles()
        {
            InitializeComponent();
        }

        private void Niveles_FormClosing(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            modo.ModoPrincipiante();
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (principianteB.Checked)
            {
                modo.ModoPrincipiante();
                this.Close();
            }
            if (medioB.Checked)
            {
                modo.ModoMedio();
                this.Close();
            }
            if (avanzadoB.Checked)
            {
                modo.ModoAvanzado();
                this.Close();
            }
        }

    }
}
