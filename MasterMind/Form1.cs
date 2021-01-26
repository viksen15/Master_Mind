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
        private int intentos;
        private int cantidadColores;
        private Combinacion combinacionActual;
        private Combinacion combinacionSecreta;

        private enum Dificultad
        {
            Facil,
            Media,
            Dificil
        }

        public Form1()
        {
            InitializeComponent();
            IniciarJuego(Dificultad.Dificil);
        }

        private void IniciarJuego(Dificultad dificultad)
        {
            // Limpiar controles
            coloresDisponibles.Controls.Clear();
            coloresSecretos.Controls.Clear();


            if (dificultad == Dificultad.Facil)
            {
                cantidadColores = 4;
                intentos = 10;
            }
            else if (dificultad == Dificultad.Media)
            {
                cantidadColores = 5;
                intentos = 8;
            }
            else
            {
                cantidadColores = 6;
                intentos = 6;
            }

            var muestraColores = new Combinacion(colores, Enumerable.Range(0, cantidadColores));
            coloresDisponibles.Controls.Add(muestraColores);
            muestraColores.Location = new Point(10, 25);

            game = new Game(cantidadColores, intentos);

            combinacionSecreta = new Combinacion(colores, game.combinacionSecreta);
            combinacionSecreta.Visible = false;
            coloresSecretos.Controls.Add(combinacionSecreta);
            combinacionSecreta.Location = new Point(10, 25);

            combinacionActual = new Combinacion(colores.Take(cantidadColores), Enumerable.Repeat(0, 4), false);
            combinacionesProbadas.Controls.Add(combinacionActual);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var combinacionProbada = combinacionActual.ObtenerYBloquear();
            var resultado = game.ProbarCombinacion(combinacionProbada);

            var resultadoTransformado = resultado.Select(i => i switch
            {
                'I' => 0,
                '?' => 1,
                'C' => 2,
                _ => 0,
            });

            var a = new Combinacion(new[] { Color.White, Color.Gray, Color.Black }, resultadoTransformado);
            resultados.Controls.Add(a);

            if (resultado.All(x => x == 'C'))
            {
                MessageBox.Show("Ganaste");
                AcabarPartida();
            }
            else if (game.combinacionesProbadas.Count >= intentos)
            {
                MessageBox.Show("Has agotado los intentos");
                AcabarPartida();
            }
            else
            {
                combinacionActual = new Combinacion(colores.Take(cantidadColores), combinacionProbada, false);
                combinacionesProbadas.Controls.Add(combinacionActual);
            }

        }

        private void AcabarPartida()
        {
            button1.Enabled = false;
            combinacionSecreta.Visible = true;
        }
    }
}
