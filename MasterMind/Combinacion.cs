using System.Drawing;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Combinacion : UserControl
    {
        private readonly Color[] coloresDisponibles;
        private int[] coloresMarcados;
        private readonly bool bloqueado;

        public Combinacion(Color[] coloresDisponibles, int[] coloresIniciales, bool bloqueado = true)
        {
            InitializeComponent();

            this.coloresDisponibles = coloresDisponibles;
            this.coloresMarcados = coloresIniciales;
            this.bloqueado = bloqueado;

            PictureBox[] pictureBoxes = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            for (int i = 0; i < coloresIniciales.Length; i++)
            {
                pictureBoxes[i].BackColor = coloresDisponibles[coloresIniciales[i]];
                pictureBoxes[i].MouseClick += Combinacion_MouseClick;
            }

            for (int i = coloresIniciales.Length; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }
        //3
        public void ComprobacionColores(Color[] colores, object obj)
        {
            if (obj is GroupBox lv)
            {
                foreach (Control c in lv.Controls)
                {
                    MessageBox.Show(c.Text);
                }
            }
            else
            {
                MessageBox.Show("no es lv");
            }
        }
        private void Combinacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox box && !bloqueado)
            {
                var index = int.Parse(box.Name.Substring(box.Name.Length - 1)) - 1;

                if(e.Button == MouseButtons.Left)
                    coloresMarcados[index] += 1; 
                else if (e.Button == MouseButtons.Right)
                    coloresMarcados[index] -= 1;

                if (coloresMarcados[index] >= coloresDisponibles.Length)
                    coloresMarcados[index] = 0;

                if (coloresMarcados[index] < 0)
                    coloresMarcados[index] = coloresDisponibles.Length - 1;

                box.BackColor = coloresDisponibles[coloresMarcados[index]];
            }
        }


    }
}


