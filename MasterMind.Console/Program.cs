using System;
using System.Collections.Generic;
using System.Linq;
using MasterMind.Library;

namespace MasterMind.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce numero de colores:");
            int colores = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Introduce numero de intentos:");
            int intentos = int.Parse(System.Console.ReadLine());

            Game game = new Game(colores, intentos);

            for (; ; )
            {
                System.Console.WriteLine("Introduce una combinación:");
                var linea = System.Console.ReadLine();

                var a = new List<int>();
                a.Add(int.Parse(linea.Substring(0, 1)));
                a.Add(int.Parse(linea.Substring(1, 1)));
                a.Add(int.Parse(linea.Substring(2, 1)));
                a.Add(int.Parse(linea.Substring(3, 1)));

                System.Console.WriteLine("Tu resultado:");
                var resultado = game.ProbarCombinacion(a.ToArray());
                System.Console.WriteLine(resultado);

                if (resultado.All(x => x == 'C')) {
                    System.Console.WriteLine("Has ganado! Jugar otra?");
                    if (System.Console.ReadLine().ToLower() != "s") 
                        break;
                    else game = new Game(colores, intentos);
                }
            }
        }
    }
}
