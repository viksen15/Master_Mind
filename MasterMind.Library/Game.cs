using System;
using System.Linq;
using System.Collections.Generic;

namespace MasterMind.Library
{
    public class Game
    {
        #region Constantes
        private const int LONGITUD_COMBINACION = 4;
        public const char OTRA_POSICION = '?';
        public const char CORRECTO = 'C';
        public const char INCORRECTO = 'I';
        #endregion

        // Random estático para que no nos genere varios con misma semilla
        private static Random rd = new Random();

        // Campos
        private readonly int colores;
        private readonly int intentos;
        public readonly int[] combinacionSecreta;
        public readonly List<IEnumerable<int>> combinacionesProbadas = new List<IEnumerable<int>>();
        public readonly List<char[]> resultados = new List<char[]>();

        public Game(int colores, int intentos)
        {
            this.colores = colores;
            this.intentos = intentos;

            combinacionSecreta = new int[LONGITUD_COMBINACION];
            for (int i = 0; i < LONGITUD_COMBINACION; i++)
            {
                combinacionSecreta[i] = rd.Next(0, colores);
            }
        }

        public char[] ProbarCombinacion(IEnumerable<int> combinacion)
        {
            if (combinacionesProbadas.Count > intentos) 
                return null;
            combinacionesProbadas.Add(combinacion);

            char[] resultado = new char[LONGITUD_COMBINACION];
            for (int i = 0; i < LONGITUD_COMBINACION; i++)
            {
                if (combinacion.ElementAt(i) == combinacionSecreta[i]) 
                    resultado[i] = CORRECTO;
                else if (combinacionSecreta.Contains(combinacion.ElementAt(i))) 
                    resultado[i] = OTRA_POSICION;
                else 
                    resultado[i] = INCORRECTO;
            }

            resultados.Add(resultado);

            return resultado;
        }
    }
}
