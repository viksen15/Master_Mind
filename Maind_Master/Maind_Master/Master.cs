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

        // ABRIMOS EL FORMULARIO DE SELECCION DE NIVEL
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Niveles nivel = new Niveles();
            nivel.Show();
        }

        // ABRIMOS EL FORMULARIO DE SELECCION DE OPCIONES DE COLOR
        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.ShowDialog();
        }
        
        // REINICIAMOS LA PARTIDA DESDE EL MENU
        private void reiniciarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // SALIMOS DE LA PARTIDA DESDE EL MENU
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // EXPLICAMOS COMO SE JUEGA DESDE EL MENU
        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La maquina escoge un número de fichas de colores, 4 en modo Principiante, 5 en modo Medio, 6 en modo Avanzado, y pone un código secreto oculto para el otro jugador. Este, tomando las fichas de colores, aventura una posibilidad." +
                "\nContestada con negras (fichas de color bien colocadas). Blancas (fichas de color con el color correcto, pero mal colocadas)." +
                "\nEl juego termina al averiguarse la combinación (es decir, se consigue una combinación con cuatro negras), o bien se agota el tablero");

        }

        // DAMOS DATOS ACERCA DEL CREADOR EN EL MENU
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY VIIKSEN ®");
        }

        // VARIABLES Y CONSTANTES USADAS
        Random rnd = new Random();
        public Color[] colores = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.DarkOrange, Color.HotPink};
        PictureBox[] bolacolores;
        Niveles nivel = new Niveles();
        const int bolasMax = 4;        
        public int intentos;
        private Color colorSeleccionado;

        // CREAMOS Y MOSTRAMOS EL PANEL DE COLORES DISPONIBLES PARA JUGAR
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

        // CREAMOS LA SOLUCION QUE POR DEFECTO NO SE MUESTRA
        private void crearSolucion()
        {
            PictureBox[] bolasolucion;
            bolasolucion = new[] { solucion1, solucion2, solucion3, solucion4 };
            for (int i=0; i<bolasolucion.Length;i++)
            { bolasolucion[i].BackColor = colores[rnd.Next(bolacolores.Length)]; }
        }

        // CREAMOS LOS COLORES QUE VA A INSERTAR EL JUGADOR ADEMAS DEL BOTON DE COMPROBACION
        private void crearLineaBola()
        {
            for (int i = 0; i < bolasMax; i++)
            {
                PictureBox bola = new PictureBox()
                {
                    BackColor = Color.White,
                    Size = new Size(22, 22)
                };
                bola.MouseClick += color;
                bolas.Controls.Add(bola);
            }

            Button check = new Button()
            {
                BackgroundImage = Properties.Resources.checkButton,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(25, 25)
            };
              check.Click += ComprobarClick;
            Bcheck.Controls.Add(check);
        }
        private void color(object sender, MouseEventArgs e)
        {
            int posicion = Array.IndexOf(colores, colorSeleccionado);
                if (e.Button == MouseButtons.Left)
                { 
                    if (posicion +1 == colores.Length)
                { colorSeleccionado = colores[0]; }
                    else { colorSeleccionado = colores[posicion + 1]; }
                }
                
                if (e.Button ==MouseButtons.Right)
                {
                    if (posicion -1 == -1)
                {
                    colorSeleccionado = colores[colores.Length - 1];
                }
                else { colorSeleccionado = colores[posicion - 1]; }
                }

            PictureBox pb = (PictureBox)sender;
            pb.BackColor = colorSeleccionado;
        }
        
        private void ComprobarClick(object sender, EventArgs e)
        {
            if (bolas.Controls.Equals(bolacolores))
            {
                for (int i = 0; i < bolasMax; i++)
                {
                    PictureBox comprobacion = new PictureBox()
                    {
                        BackColor = Color.Red,
                        Size = new Size(22, 22)
                    };
                    bolas.Controls.Add(comprobacion);
                }
            }
        }

        // EJECUTAMOS LO NECESARIO AL INICIAR LA EJECUCION
        private void Master_Load(object sender, EventArgs e)
        {
            nivel.ShowDialog();
            crearColores();
            crearSolucion();
            crearLineaBola();
        }

        // MOSTRAMOS LA COMBINACION SECRETA
        private void mostrar_Click(object sender, EventArgs e)
        {
            solucion1.Visible = true;
            solucion2.Visible = true;
            solucion3.Visible = true;
            solucion4.Visible = true;

        }










        /*
        private void JugadaClick(object sender, EventArgs e)
        {
            Color seleccionado = ColoresDisponibles.BackColor;
            int posicion = Array.IndexOf(bolacolores, seleccionado);
        }*/




    }
}
