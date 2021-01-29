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
            if (nivel is null) CambiarNivel();

            nivelToolStripMenuItem.Enabled = false;
            
            LlenarSolucion();

            intento = 0;

            colorSeleccionado = coloresDisponibles[0];
            pictureBox1.BackColor = colorSeleccionado;

            NuevaJugada();
        }
        private void LlenarColoresDisponibles() {
            ActualizarPanel(ref pnlColoresDisponibles, false);

            for (int i = 0; i < coloresDisponibles.Length; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = coloresDisponibles[i],

                };

                pnlColoresDisponibles.Controls.Add(pb);
            }
        }
        private void LlenarSolucion() {
            ActualizarPanel(ref pnlCombinacionSecreta, false);

            solucion = new Color[nivel.NumColores];
            for (int i = 0; i < nivel.NumColores; i++) {
                Color c = coloresDisponibles[rnd.Next(coloresDisponibles.Length)];

                PictureBox pb = new PictureBox() {
                    BackColor = c
                };

                pnlCombinacionSecreta.Controls.Add(pb);

                solucion[i] = c;
            }
        }
        private void NuevaJugada() {
            for (int i = 0; i < nivel.NumColores; i++) {
                PictureBox pb = new PictureBox() {
                    BackColor = Color.White,
                    Name = "colordisp"
                };
                pb.MouseClick += BotonJugadaClick;

                pnlJugadas.Controls.Add(pb, i, intento);
            }

            Button btnTest = new Button() {
                Image = Properties.Resources.visto,
                Size = new Size(44, 50),
                BackColor = Color.White
            };
            btnTest.Click += BotonComprobarClick;

            pnlJugadas.Controls.Add(btnTest, nivel.NumColores, intento);
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

            PictureBox p = (PictureBox)sender;
            p.BackColor = colorSeleccionado;
        }
        private void BotonJugadaClick(object sender, MouseEventArgs e) {
            CambiarColorSeleccionado(sender, e);
        }
        private void BotonComprobarClick(object sender, EventArgs e) {
            Color[] jugada = new Color[nivel.NumColores];
            Color[] negras = new Color[nivel.NumColores];

            for (int i = 0; i < nivel.NumColores; i++) {
                Control c = pnlJugadas.GetControlFromPosition(i, intento);

                if (c is PictureBox) {
                    jugada[i] = c.BackColor;
                }
            }

            if (Enumerable.SequenceEqual(jugada, solucion)) {
                MessageBox.Show("Has acertado la combinación.");
            } else if (intento == nivel.Intentos) {
                MessageBox.Show("Has agotado todos los intentos.");
            } else {
                ComprobarJugada(jugada);

                pnlJugadas.Controls.Remove((Button)sender);

                AddFilaPanel(ref pnlJugadas);
                AddFilaPanel(ref pnlTesting);

                intento += 1;

                NuevaJugada();
            }
        }
        private void AddFilaPanel(ref TableLayoutPanel panel) {
            panel.RowCount += 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panel.Size = new Size(panel.Size.Width, panel.Size.Height + 56);
        }
        private void ComprobarJugada(Color[] jugada) {
            Color[] BlancasColocadas = new Color[nivel.NumColores];
            int numFichasColocadas = 0;

            for (int i = 0; i < jugada.Length; i++) {
                if (jugada[i] == solucion[i]) {
                    PictureBox pb = new PictureBox() {
                        BackColor = Color.Black,
                    };

                    pnlTesting.Controls.Add(pb, numFichasColocadas, intento);
                    numFichasColocadas++;
                }
            }            

            for (int i = 0; i < jugada.Length; i++) {
                Color c = jugada[i];

                if (c != solucion[i] && solucion.Contains(c)) {
                    if (!BlancasColocadas.Contains(c)) {
                        PictureBox pb = new PictureBox() {
                            BackColor = Color.White,
                        };

                        pnlTesting.Controls.Add(pb, numFichasColocadas, intento);
                        numFichasColocadas++;

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
            CambiarNivel();
        }
        private void CambiarNivel() {
            // Mostramos el formulario de selección de nivel
            frmSelectorNivel f = new frmSelectorNivel();

            DialogResult dr = f.ShowDialog();

            if (dr == DialogResult.OK) {
                nivel = f.NivelSeleccionado;
            }

            coloresDisponibles = nivel.ColoresDisponibles;

            // Modificamos la label que indica el nivel
            lblNivel.Text = "Nivel seleccionado: " + nivel.Nombre;

            ActualizarPanel(ref pnlJugadas, true);
            ActualizarPanel(ref pnlTesting, false);

            LlenarColoresDisponibles();
        }
        private void ActualizarPanel(ref TableLayoutPanel panel, bool boton) {
            panel.ColumnStyles.Clear();

            panel.ColumnCount = boton ? nivel.NumColores + 1 : nivel.NumColores;

            panel.Size = new Size(50 * panel.ColumnCount, 56);

            for (int i = 0; i < panel.ColumnCount; i++) {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            }
        }
        private void btnMostrarSolucion_Click(object sender, EventArgs e) {
            pnlCombinacionSecreta.Visible = !pnlCombinacionSecreta.Visible;
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e) {
            frmSelectorColor f = new frmSelectorColor(coloresDisponibles);
            f.Show();
        }
    }
}


