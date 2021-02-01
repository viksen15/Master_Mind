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
    public partial class frmSelectorColor : Form {
        private Color[] seleccionActual;
        public Color[] Seleccion {
            get => seleccionActual;
            set => seleccionActual = value; 
        }
        public frmSelectorColor(Color[] seleccion) {
            InitializeComponent();

            seleccionActual = seleccion;

            mostrarColores();
        }

        private void mostrarColores() {
            int x = 12;

            PictureBox p1 = CrearPictureBox(x, seleccionActual[0], 0);

            Controls.Add(p1);

            for (int i = 1; i < seleccionActual.Length; i++) {
                x += 56;

                PictureBox p = CrearPictureBox(x, seleccionActual[i], i);
                p.Click += SeleccionarColor;
                Controls.Add(p);
            }
        }

        PictureBox CrearPictureBox(int x, Color color, int number) {
            return new PictureBox() { 
                Location = new Point(x, 12),
                Name = "p" + number,
                Size = new Size(50, 50),
                BackColor = color,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private void SeleccionarColor(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            Color colorActual = p.BackColor;

            ColorDialog cd = new ColorDialog();
            cd.Color = colorActual;

            if (cd.ShowDialog() == DialogResult.OK) {
                p.BackColor = cd.Color;

                string n = p.Name.Substring(1);
                int posicion = int.Parse(n);

                seleccionActual[posicion] = cd.Color;
            }                    
        }
        private void btnAceptar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }
        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
