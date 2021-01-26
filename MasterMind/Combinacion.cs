using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MasterMind
{
    public partial class Combinacion : UserControl
    {
        private readonly IEnumerable<Color> coloresDisponibles;
        private readonly PictureBox[] pictureBoxes;
        private bool bloqueado;

        public Combinacion(IEnumerable<Color> coloresDisponibles, IEnumerable<int> coloresIniciales, bool bloqueado = true)
        {
            InitializeComponent();

            this.coloresDisponibles = coloresDisponibles;
            this.bloqueado = bloqueado;

            pictureBoxes = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            for (int i = 0; i < coloresIniciales.Count(); i++)
            {
                pictureBoxes[i].BackColor = coloresDisponibles.ElementAt(coloresIniciales.ElementAt(i));
                pictureBoxes[i].MouseClick += Combinacion_MouseClick;
            }

            for (int i = coloresIniciales.Count(); i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        public IEnumerable<int> ObtenerYBloquear()
        {
            bloqueado = true;
            List<int> resultado = new List<int>();
            // Aqui vamos a construir resultado
            foreach(PictureBox p in pictureBoxes)
            {
                if (p.Visible)
                    resultado.Add(ObtenerIndice(p.BackColor));
            }
            return resultado;
        }

        private int ObtenerIndice(Color color)
        {
            return Enumerable
                    .Range(0, coloresDisponibles.Count())
                    .Where(i => coloresDisponibles.ElementAt(i) == color)
                    .First();
        }

        private void Combinacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox box && !bloqueado)
            {
                // Obtener indice del color en coloresDisponibles
                var index = ObtenerIndice(box.BackColor);
                // Aumentarlo o disminuirlo segun click
                if(e.Button == MouseButtons.Left)
                    index += 1;
                else if (e.Button == MouseButtons.Right)
                    index -= 1;

                // Comprobar que no salga de limites
                if (index >= coloresDisponibles.Count())
                    index = 0;

                if (index < 0)
                    index = coloresDisponibles.Count() - 1;

                // Cambiar color
                box.BackColor = coloresDisponibles.ElementAt(index);
            }
        }


    }
}


