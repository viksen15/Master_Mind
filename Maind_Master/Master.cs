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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Niveles nivel = new Niveles();
            nivel.Show();
        }
        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La maquina escoge un número de fichas de colores, 4 en modo Principiante, 5 en modo Medio, 6 en modo Avanzado, y pone un código secreto oculto para el otro jugador. Este, tomando las fichas de colores, aventura una posibilidad." +
                "\nContestada con negras (fichas de color bien colocadas). Blancas (fichas de color con el color correcto, pero mal colocadas)." +
                "\nEl juego termina al averiguarse la combinación (es decir, se consigue una combinación con cuatro negras), o bien se agota el tablero");

        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY VIIKSEN ®");
        }

        Random rnd = new Random();
        public Color[] colores = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.DarkOrange, Color.HotPink};
        PictureBox[] bolacolores;
        Niveles nivel = new Niveles();
        const int bolasMax = 4;
        public int intentos;

        private void crearColores()
        {
            if (nivel.nivel == 0)
            {
                bolacolores = new[] { bolacolor1, bolacolor2, bolacolor3, bolacolor4 };
                for (int i = 0; i < bolacolores.Length; i++)
                {
                    bolacolores[i].BackColor = colores[i];
                }
            }

            if (nivel.nivel == 1)
            {
                bolacolores = new[] { bolacolor1, bolacolor2, bolacolor3, bolacolor4, bolacolor5 };
                for (int i = 0; i < bolacolores.Length; i++)
                {
                    bolacolores[i].BackColor = colores[i];
                }
            }

            if (nivel.nivel == 2)
            {
                bolacolores = new[] { bolacolor1, bolacolor2, bolacolor3, bolacolor4, bolacolor5, bolacolor6 };
                for (int i = 0; i < bolacolores.Length; i++)
                {
                    bolacolores[i].BackColor = colores[i];
                }
            }

        }
        private void crearSolucion()
        {
            PictureBox[] bolasolucion;
            bolasolucion = new[] { solucion1, solucion2, solucion3, solucion4 };
            for (int i=0; i<bolasolucion.Length;i++)
            { bolasolucion[i].BackColor = colores[rnd.Next(bolacolores.Length)]; }
        }

        private void Master_Load(object sender, EventArgs e)
        {
            nivel.ShowDialog();
            crearColores();
            crearSolucion();
            crearLineaBola();
        }
        private void crearLineaBola()
        {
            for (int i = 0; i < bolasMax; i++)
            {
                PictureBox bola = new PictureBox()
                {
                    BackColor = Color.White,
                    Size = new Size(22, 22)
                }; 
                bolas.Controls.Add(bola);
            }

            Button check = new Button()
            {
                BackgroundImage = Properties.Resources.checkButton,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(25, 25)
            };
          //  check.Click += ComprobarClick;
            Bcheck.Controls.Add(check);
        }








        /*
        private void JugadaClick(object sender, EventArgs e)
        {
            Color seleccionado = ColoresDisponibles.BackColor;
            int posicion = Array.IndexOf(bolacolores, seleccionado);
        }*/




    }
}
