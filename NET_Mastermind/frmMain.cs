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

        private Color[] coloresDisponibles = { Color.Red, Color.Blue, Color.Green, Color.Yellow };

        private Color[] solucion;
        private Color colorSeleccionado;

        private Nivel nivel;

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
            //pictureBox1.BackColor = colorSeleccionado;

            NuevaJugada();
        }
        private void LlenarColoresDisponibles() {
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = coloresDisponibles[i],

                };

                pnlColoresDisponibles.Controls.Add(pb);
            }
        }
        private void LlenarSolucion() {
            solucion = new Color[4];
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                Color c = coloresDisponibles[rnd.Next(coloresDisponibles.Length)];

                PictureBox pb = new PictureBox() {
                    BackColor = c
                };

                pnlCombinacionSecreta.Controls.Add(pb);

                solucion[i] = c;
            }
        }
        private void NuevaJugada() {
            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = Color.White,
                    Name = "colordisp"
                };
                pb.Click += BotonJugadaClick;
                pb.MouseEnter += MarcarColorSeleccionado;
                pb.MouseLeave += QuitarColorSeleccionado;

                pnlJugadas.Controls.Add(pb, i, intento);
            }

            Button btnTest = new Button() {
                Image = Properties.Resources.visto,
                Size = new Size(44, 50),
                BackColor = Color.White
            };
            btnTest.Click += BotonComprobarClick;

            pnlJugadas.Controls.Add(btnTest, coloresDisponibles.Length, intento);
        }

        private void QuitarColorSeleccionado(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            p.BackColor = Color.White;
        }

        private void MarcarColorSeleccionado(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            p.BackColor = colorSeleccionado;
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

            //pictureBox1.BackColor = colorSeleccionado;
        }
        private void BotonJugadaClick(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            p.BackColor = colorSeleccionado;
        }
        private void BotonComprobarClick(object sender, EventArgs e) {
            Color[] jugada = new Color[4];

            for (int i = 0; i < coloresDisponibles.Length; i++) {
                Control c = pnlJugadas.GetControlFromPosition(i, intento);
                if (c is PictureBox) jugada[i] = c.BackColor;
            }

            ComprobarNegras(jugada);
            ComprobarBlancas(jugada);

            if (jugada == solucion) {
                MessageBox.Show("Has acertado la combinación.");
            } else if (intento == 10) {
                MessageBox.Show("Has agotado todos los intentos.");
            } else {
                pnlJugadas.Controls.Remove((Button)sender);

                // Añadimos una fila al panel de jugadas
                pnlJugadas.RowCount += 1;
                pnlJugadas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                pnlJugadas.Size = new Size(pnlJugadas.Size.Width, pnlJugadas.Size.Height + 56);

                // Añadimos una fila al panel de testing
                pnlTesting.RowCount += 1;
                pnlTesting.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                pnlTesting.Size = new Size(pnlTesting.Size.Width, pnlTesting.Size.Height + 56);

                intento += 1;

                NuevaJugada();
            }
        }
        private void ComprobarNegras(Color[] jugada) {
            for (int i = 0; i < jugada.Length; i++) {
                if (jugada[i] == solucion[i]) {
                    PictureBox pb = new PictureBox() {
                        BackColor = Color.Black,
                    };

                    pnlTesting.Controls.Add(pb, i, intento);
                }
            }
        }
        private void ComprobarBlancas(Color[] jugada) {
            Color[] BlancasColocadas = new Color[4];

            for (int i = 0; i < jugada.Length; i++) {
                Color c = jugada[i];

                if (c != solucion[i] && solucion.Contains(c)) {
                    if (!BlancasColocadas.Contains(c)) {
                        PictureBox pb = new PictureBox() {
                            BackColor = Color.White,
                        };

                        pnlTesting.Controls.Add(pb, i, intento);

                        BlancasColocadas[i] = c;
                    }
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
            Close();
        }

        private void nivelToolStripMenuItem_Click(object sender, EventArgs e) {
            frmSelectorNivel f = new frmSelectorNivel();

            DialogResult dr = f.ShowDialog();

            if (dr == DialogResult.OK) {
                nivel = f.NivelSeleccionado;
            }

            lblNivel.Text = "Nivel seleccionado: " + nivel.Nombre;
        }
    }
}
