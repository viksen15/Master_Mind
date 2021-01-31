using System;
using System.Linq;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class SeleccionarColores : Form
    {
        private readonly Main main;
        public SeleccionarColores(Main main)
        {
            InitializeComponent();
            this.main = main;
            var colores = main.colores;
            var cantidadColores = main.cantidadColores;

            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            pictureBox1.Click += HandleColorPick;
            pictureBox2.Click += HandleColorPick;
            pictureBox3.Click += HandleColorPick;
            pictureBox4.Click += HandleColorPick;

            if (cantidadColores > 4)
            {
                pictureBox5.Click += HandleColorPick;
                pictureBox5.Visible = true;
                if (cantidadColores > 5)
                {
                    pictureBox6.Click += HandleColorPick;
                    pictureBox6.Visible = true;
                }
                else
                {
                    pictureBox6.BackColor = colores[5];
                }
            }
            else
            {
                pictureBox5.BackColor = colores[4];
                pictureBox6.BackColor = colores[5];
            }

        }

        private void HandleColorPick(object sender, EventArgs e)
        {
            var s = (PictureBox)sender;

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                s.BackColor = MyDialog.Color;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var arrColores = new[]
            {
                pictureBox1.BackColor,
                pictureBox2.BackColor,
                pictureBox3.BackColor,
                pictureBox4.BackColor,
                pictureBox5.BackColor,
                pictureBox6.BackColor
            };
            if(arrColores.Length != arrColores.Distinct().Count())
            {
                MessageBox.Show("Debes seleccionar colores distintos");
                return;
            }
            main.colores = arrColores;
            
            main.IniciarJuego();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
