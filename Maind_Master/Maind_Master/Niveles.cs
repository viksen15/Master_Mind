using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maind_Master
{
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        public int nivel = 0;
        private void cancelarN_Click(object sender, EventArgs e)
        {
            nivel = 0;
            this.Close();
        }

        private void aceptarN_Click(object sender, EventArgs e)
        {
            if (Bprincipiante.Checked)
            {
                nivel = 0;
                this.Close();
            }
            if (Bmedio.Checked)
            {
                nivel = 1;
                this.Close();
            }
            if (Bavanzado.Checked)
            {
                nivel = 2;
                this.Close();
            }
        }
    }
}
