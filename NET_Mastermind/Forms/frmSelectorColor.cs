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
            PictureBox p1 = new PictureBox();
            p1.Location = new Point(x, 12);
            p1.Name = "p" + number;
            p1.Size = new Size(50, 50);
            p1.BackColor = color;
            p1.BorderStyle = BorderStyle.FixedSingle;            

            return p1;
        }

        private void SeleccionarColor(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            Color colorActual = p.BackColor;

            ColorDialog cd = new ColorDialog();
            cd.Color = colorActual;

            if (cd.ShowDialog() == DialogResult.OK) {
                p.BackColor = cd.Color;
            }

            colorActual = cd.Color;

            
        }
    }
}
