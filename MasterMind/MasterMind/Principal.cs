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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        int colores = 4;
        int intentos = 10;
        

        private void juegoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Niveles niveles = new Niveles();
            niveles.Show(this);
            this.Hide();
        }
        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show(this);
            
        }

        public bool ModoPrincipiante()
        {
            Principal principiante = new Principal();
            Task.Run(() => principiante.ShowDialog());
            colores = 4;
            principiante.color5.Visible = false;
            principiante.color6.Visible = false;
            return true;
        }

        public bool ModoMedio()
        {
            Principal medio = new Principal();
            Task.Run(() => medio.ShowDialog());
            colores = 5;
            medio.color6.Visible = false;
            crearColores();
            return true;
        }

        public bool ModoAvanzado()
        {
            Principal avanzado = new Principal();
            Task.Run(() => avanzado.ShowDialog());
            colores = 6;
            crearColores();
            return true;
        }

        private void crearColores()
        {
            Random rnd = new Random();
            Color rndColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            // Color rndColor1 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor2 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor3 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor4 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor5 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor6 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            color1.BackColor = rndColor;
            color2.BackColor = rndColor;
            color3.BackColor = rndColor;
            color4.BackColor = rndColor;
            color5.BackColor = rndColor;
            color6.BackColor = rndColor;

        }

        private void crearSolucion()
        {
            Random rnd = new Random();
            Color rndColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            //  Color rndColor1 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor2 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor3 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //  Color rndColor4 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            solucion1.BackColor = rndColor;
            solucion2.BackColor = rndColor;
            solucion3.BackColor = rndColor;
            solucion4.BackColor = rndColor;
        }



        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La maquina escoge un número de fichas de colores, 4 en modo Principiante, 5 en modo Medio, 6 en modo Avanzado, y pone un código secreto oculto para el otro jugador. Este, tomando las fichas de colores, aventura una posibilidad." +
                            "\nContestada con negras (fichas de color bien colocadas). Blancas (fichas de color con el color correcto, pero mal colocadas)." +
                            "\nEl juego termina al averiguarse la combinación (es decir, se consigue una combinación con cuatro negras), o bien se agota el tablero");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY VIIKSEN ®");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickColores(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            crearColores();
            crearSolucion();
            
        }

        private void check(object sender, EventArgs e)
        {
            
        }


        private void coloresDispo_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    tableLayoutPanel1.Controls.Add(color1,1,1);
                    tableLayoutPanel1.Controls.Add(color2,2,1);
                    tableLayoutPanel1.Controls.Add(color3,3,1);
                    tableLayoutPanel1.Controls.Add(color4,4,1);

                    break;
                case MouseButtons.Right:
                    break;
            }
               
        }
    }
    
}
