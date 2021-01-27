using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Mastermind {
    public partial class frmSelectorNivel : Form {
        private Nivel[] niveles = new Nivel[3] { new Nivel(4, 10, "Principiante"), new Nivel(5, 8, "Intermedio"), new Nivel(6, 6, "Difícil") };
        private Nivel nivelSeleccionado;
        public Nivel NivelSeleccionado {
            get => nivelSeleccionado;
        }
        
        public frmSelectorNivel() {
            InitializeComponent();

            nivelSeleccionado = niveles.First();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();

            foreach (RadioButton rb in gbSelectorNivel.Controls) {
                if (rb.Checked) nivelSeleccionado = niveles[int.Parse(rb.Tag.ToString())];
            }            
        }
    }
}
