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

        private void Opciones_FormClosing(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColorSelec1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { ColorSelec1.BackColor = colorDialog1.Color; }
        }

        private void ColorSelec2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            { ColorSelec2.BackColor = colorDialog2.Color; }
        }
        private void ColorSelec3_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK)
            { ColorSelec3.BackColor = colorDialog3.Color; }
        }
        private void ColorSelec4_Click(object sender, EventArgs e)
        {
            if (colorDialog4.ShowDialog() == DialogResult.OK)
            { ColorSelec4.BackColor = colorDialog4.Color; }
        }
        private void ColorSelec5_Click(object sender, EventArgs e)
        {
            if (colorDialog5.ShowDialog() == DialogResult.OK)
            { ColorSelec5.BackColor = colorDialog5.Color; }
        }
        private void ColorSelec6_Click(object sender, EventArgs e)
        {
            if (colorDialog6.ShowDialog() == DialogResult.OK)
            { ColorSelec6.BackColor = colorDialog6.Color; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
