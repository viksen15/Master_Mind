using MasterMind.Library;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MasterMind
{
    public partial class Main : Form
    {
        public Color[] colores = new[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Pink, Color.Brown };

        Game game;
        private int intentos;
        private int cantidadColores;
        private Combinacion combinacionActual;
        private Combinacion combinacionSecreta;
        private Dificultad dificultad = Dificultad.Facil;

        private enum Dificultad
        {
            Facil,
            Media,
            Dificil
        }

        public Main()
        {
            InitializeComponent();
            dificultadMenuFacil.Click += Dificultad_Changed;
            dificultadMenuMediana.Click += Dificultad_Changed;
            dificultadMenuDificil.Click += Dificultad_Changed;
            comenzarMenu.Click += ComenzarMenu_Click;
            cancelarPartidaMenu.Click += CancelarPartidaMenu_Click;
        }

        private void CancelarPartidaMenu_Click(object sender, EventArgs e)
        {
            AcabarPartida();
        }

        private void ComenzarMenu_Click(object sender, EventArgs e)
        {
            IniciarJuego(dificultad);
        }

        private void Dificultad_Changed(object sender, EventArgs e)
        {
            if (sender == dificultadMenuFacil)
            {
                dificultadMenuFacil.CheckState = CheckState.Checked;
                dificultadMenuMediana.CheckState = CheckState.Unchecked;
                dificultadMenuDificil.CheckState = CheckState.Unchecked;
                dificultad = Dificultad.Facil;
            }
            else if (sender == dificultadMenuMediana)
            {
                dificultadMenuFacil.CheckState = CheckState.Unchecked;
                dificultadMenuMediana.CheckState = CheckState.Checked;
                dificultadMenuDificil.CheckState = CheckState.Unchecked;
                dificultad = Dificultad.Media;
            }
            else if (sender == dificultadMenuDificil)
            {
                dificultadMenuFacil.CheckState = CheckState.Unchecked;
                dificultadMenuMediana.CheckState = CheckState.Unchecked;
                dificultadMenuDificil.CheckState = CheckState.Checked;
                dificultad = Dificultad.Dificil;
            }
        }

        private void IniciarJuego(Dificultad dificultad)
        {
            // Limpiar controles
            coloresDisponibles.Controls.Clear();
            coloresSecretos.Controls.Clear();
            combinacionesProbadas.Controls.Clear();
            resultados.Controls.Clear();

            comenzarMenu.Enabled = false;
            cancelarPartidaMenu.Enabled = true;
            dificultadMenu.Enabled = false;
            btnProbar.Enabled = true;


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

            var resultadoTransformado = resultado
                .Select(caracter => caracter switch
                {
                    '?' => 0,
                    'C' => 1,
                    'I' => 2,
                    _ => 2,
                })
                .Where(num => num < 2)
                .OrderByDescending(num => num);

            var a = new Combinacion(new[] { Color.White, Color.Black }, resultadoTransformado);
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
            btnProbar.Enabled = false;
            combinacionSecreta.Visible = true;
            comenzarMenu.Enabled = true;
            cancelarPartidaMenu.Enabled = false;
            dificultadMenu.Enabled = true;
        }
    }
}
