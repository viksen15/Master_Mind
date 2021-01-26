using MasterMind.Library;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        public Color[] colores = new[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Pink, Color.Brown };

        Game game;

        public Form1()
        {
            InitializeComponent();
            var a = new Combinacion(colores, new[] { 0, 1, 2, 3, 4, 5 });
            coloresDisponibles.Controls.Add(a);
            a.Location = new Point(10, 25);

            //var game = new Game(4, 10);
            game = new Game(4, 10);

            var b = new Combinacion(colores, game.combinacionSecreta);
            coloresSecretos.Controls.Add(b);
            b.Location = new Point(10, 25);

            var c = new Combinacion(colores, new[] { 0, 0, 0, 0 }, false);
            combinacionesProbadas.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new Combinacion(colores, new[] { 0, 0, 0, 0 }, false);
            combinacionesProbadas.Controls.Add(a);

            var b = new List<int>();

            //b.Add(int.Parse(linea.Substring(0, 1)));
            
            var x = game.combinacionesProbadas;
            foreach (var i in x)
            {
                MessageBox.Show(i.ToString());
            }

            //var resultado = game.ProbarCombinacion();
            //Console.WriteLine(resultado);


            //a.ComprobacionColores(colores, coloresSecretos);
            //resultados.Controls.Add(b);

        }
    }
}
