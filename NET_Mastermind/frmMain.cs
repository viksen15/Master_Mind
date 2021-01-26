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
    public partial class frmMain : Form {
        private Random rnd = new Random();

        private Color[] coloresDisponibles = {
            Color.Red, Color.Blue, Color.Green, Color.Yellow
        };

        private Color[] solucion;

        private Color colorSeleccionado;

        private int intento;
        public frmMain() {
            InitializeComponent();
        }
        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e) {
            NuevaPartida();
        }
        private void NuevaPartida() {
            LlenarColoresDisponibles();
            LlenarSolucion();

            intento = 0;

            colorSeleccionado = coloresDisponibles[0];
            solucion = new Color[4];

            NuevaJugada();
        }
        private void LlenarColoresDisponibles() {
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = coloresDisponibles[i]
                };

                pnlColoresDisponibles.Controls.Add(pb);
            }
        }
        private void LlenarSolucion() {
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = coloresDisponibles[rnd.Next(coloresDisponibles.Length)]
                };

                pnlCombinacionSecreta.Controls.Add(pb);

                solucion[i] = coloresDisponibles[rnd.Next(coloresDisponibles.Length)];
            }
        }
        private void NuevaJugada() {
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = Color.White,
                };

                pb.Click += BotonJugadaClick;

                pnlJugadas.Controls.Add(pb, i, intento);
            }

            Button btnTest = new Button() {
                Image = Properties.Resources.visto,
                Size = new Size(44, 50),
                BackColor = Color.White
            };

            pnlJugadas.Controls.Add(btnTest);
        }
        private void CambiarColorSeleccionado(object sender, MouseEventArgs e) {
            int posicionActiva = Array.IndexOf(coloresDisponibles, colorSeleccionado);

            if (e.Button == MouseButtons.Left) {
                if (posicionActiva + 1 == coloresDisponibles.Length) {
                    colorSeleccionado = coloresDisponibles[0];
                } else {
                    colorSeleccionado = coloresDisponibles[posicionActiva + 1];
                }
            }

            if (e.Button == MouseButtons.Right) {
                if (posicionActiva - 1 == -1) {
                    colorSeleccionado = coloresDisponibles[coloresDisponibles.Length - 1];
                } else {
                    colorSeleccionado = coloresDisponibles[posicionActiva - 1];
                }
            }

            pictureBox1.BackColor = colorSeleccionado;
        }
        private void BotonJugadaClick(object sender, System.EventArgs e) {
            PictureBox p = (PictureBox)sender;
            p.BackColor = colorSeleccionado;
        }
    }
}
