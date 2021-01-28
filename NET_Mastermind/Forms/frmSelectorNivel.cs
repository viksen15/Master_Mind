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
        private Color[] c1 = { Color.Red, Color.Blue, Color.Green, Color.Yellow };
        private Color[] c2 = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange };
        private Color[] c3 = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Magenta };

        private Nivel[] niveles;
        private Nivel nivelSeleccionado;
        public Nivel NivelSeleccionado {
            get => nivelSeleccionado;
        }

        public frmSelectorNivel() {
            InitializeComponent();

            niveles = new Nivel[3] {
                new Nivel(4, 10, "Principiante", c1),
                new Nivel(5, 8, "Intermedio", c2),
                new Nivel(6, 6, "Difícil", c3)
            };

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
