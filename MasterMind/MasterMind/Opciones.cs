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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }
        // CERRAMOS EL FORMULARIO AL CERRAR LA VENTANA
        private void Opciones_FormClosing(object sender, EventArgs e)
        {
            this.Close();
        }
        // OCULTAMOS PICTUREBOX DE SELECCION DEPENDIENDO DEL NIVEL SELECCIONADO
        /*  private void cuantosColores()
          {
              if (ModoPrincipiante())
              {
                  ColorSelec5.Visible = false;
                  ColorSelec6.Visible = false;
                  ColorSelec5.Enabled = false;
                  ColorSelec6.Enabled = false;
              }
              if (ModoMedio())
              {
                  ColorSelec6.Visible = false;
                  ColorSelec6.Enabled = false;
              }
          }*/
        // LE DAMOS COLOR A LOS PICTUREBOX DISPONIBLES
        private void colorClick(object sender, EventArgs e)
        {
          // cuantosColores();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
             ColorSelec1.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                ColorSelec2.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                ColorSelec3.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                ColorSelec4.BackColor = colorDialog1.Color;

            if (colorDialog1.ShowDialog() == DialogResult.OK && ColorSelec5.Enabled == true)
                ColorSelec5.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK && ColorSelec6.Enabled == true)
                ColorSelec6.BackColor = colorDialog1.Color;
        }
        private void button1_Click(object sender, EventArgs e)
        { 

        }
    }
}
