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
        // VARIABLES PRINCIPALES
        int colores = 4;
        int intentosRestantes = 10;
        int bola = 4;
   //     private int[,] intentos = new int[4, 10];
  //      private int[] secret = new int[4];
   //     private int[] acierto = new int[] { -1, -1, -1, -1 };
      //   PictureBox[] dispo = new PictureBox[4];



        // REINICIAMOS PARTIDA CON EL BOTON JUEGO NUEVO
        private void juegoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        // MOSTRAMOS EL FORMULARIO DE SELECCION DE NIVEL PARA PODER SELECCIONARLO
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Niveles niveles = new Niveles();
            niveles.ShowDialog();
            if (niveles.nivel == 0)
                ModoPrincipiante();
            if (niveles.nivel == 1)
                ModoMedio();
            if (niveles.nivel == 2)
                ModoAvanzado();
          //  this.Hide();
            
        }

        // MOSTRAMOS EL FORMULARIO DE SELECCION DE COLORES PARA PODER SELECCIONARLOS
        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show(this);
        }

        // EJECUTAMOS EL MODO PRINCIPIANTE CON SOLO 4 COLORES
        public void ModoPrincipiante()
        {
            colores = 4;
            color5.Visible = false;
            color5.Enabled = false;
            color6.Visible = false;
            color6.Enabled = false;
        }

        // EJECUTAMOS EL MODO MEDIO CON 5 COLORES
        public void ModoMedio()
        {
            colores = 5;
            color6.Visible = false;
            color6.Enabled = false;
        }

        // EJECUTAMOS EL MODO AVANZADO CON 6 COLORES
        public void ModoAvanzado()
        {
            colores = 6;
        }

        // CREAMOS LOS COLORES DE JUEGO ALEATORIAMENTE
        public void crearColores()
        {
            Random rnd = new Random();
            
            Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

             color1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             color2.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             color3.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             color4.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             color5.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             color6.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

      //      color1.BackColor = secret[0];
       //     color2.BackColor = secret[1];
        //    color3.BackColor = dispo;
       //     color4.BackColor = dispo[3];
     //       color4.BackColor = dispo[4];
      //      color5.BackColor = dispo[5];
      //      color6.BackColor = dispo[6];
        }


        // CREAMOS LA SOLUCION DE COLORES DE JUEGO ALEATORIAMENTE
        private void crearSolucion()
        {
            Random rnd = new Random();
            
            Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            solucion1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            solucion2.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            solucion3.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            solucion4.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

           // solucion1.BackColor = secret[0];
           // solucion2.BackColor = secret[1];
          //  solucion3.BackColor = secret[2];
          //  solucion4.BackColor = secret[3];

        }


        // AÑADIMOS LOS DATOS DE COMO JUGAR EN EL MENU
        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La maquina escoge un número de fichas de colores, 4 en modo Principiante, 5 en modo Medio, 6 en modo Avanzado, y pone un código secreto oculto para el otro jugador. Este, tomando las fichas de colores, aventura una posibilidad." +
                            "\nContestada con negras (fichas de color bien colocadas). Blancas (fichas de color con el color correcto, pero mal colocadas)." +
                            "\nEl juego termina al averiguarse la combinación (es decir, se consigue una combinación con cuatro negras), o bien se agota el tablero");
        }

        // AÑADIMOS LOS DATOS ACERCA DE EN EL MENU
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY VIIKSEN ®");
        }

        // SALIMOS DEL JUEGO AL PULSAR SALIR EN EL MENU
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // CARGAMOS LOS METODOS DURANTE LA EJECUCION DEL PROGRAMA
        private void Principal_Load(object sender, EventArgs e)
        {
            crearColores();
            crearSolucion();

            Niveles niveles = new Niveles();
            niveles.ShowDialog();
            if (niveles.nivel == 0)
                ModoPrincipiante();
            if (niveles.nivel == 1)
                ModoMedio();
            if (niveles.nivel == 2)
                ModoAvanzado();

        }

        // BOTON DE COMPROBACION PARA CADA FILA INSERTADA
        /*  private void check(object sender, EventArgs e)
          {
              int[] check = new int[] { -1, -1, -1, -1 };
              int secretIndex, dispoIndex;
              int colorYposicion = 0, soloColor = 0;

              for (secretIndex = 0; secretIndex<4; secretIndex++)
              {
                  if (secret[secretIndex] == dispo[secretIndex])
                  {
                      check[secretIndex] = 1; // COLOR Y POSICION IGUALES
                      colorYposicion++;
                  }
              }
          }
        */

        private void Juego()
        {
        }

        // DIFERENCIA EL CLIC DERECHO Y EL IZQUIERDO DEL RATON
        private void clicRaton(object sender, MouseEventArgs e)
        {

            /*  PictureBox pb = new PictureBox();
            pb = (PictureBox)sender;*/


            
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    tableLayoutPanel1.Controls.Add((PictureBox)sender, 0, 0);
               //     tableLayoutPanel1.Controls.Add(color2, 1, 0);
                 //   tableLayoutPanel1.Controls.Add(color3, 2, 0);
                //    tableLayoutPanel1.Controls.Add(color4, 3, 0);
                    break;
                case MouseButtons.Right:
                    
                    tableLayoutPanel1.Controls.Add((PictureBox)sender,3,0);
                   // tableLayoutPanel1.Controls.Add(color2, 2, 0);
                    //tableLayoutPanel1.Controls.Add(color3, 1, 0);
                   // tableLayoutPanel1.Controls.Add(color4, 0, 0);

                    break;

            }
        }
    }
    
}
