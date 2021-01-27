using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Mastermind {
    public class Nivel {
        private int _numColores;
        private int _intentos;
        private string _nombre;
        public int NumColores {
            get => _numColores;
            set { _numColores = value; }
        }
        public int Intentos {
            get => _intentos;
            set { _intentos = value; }
        }

        public string Nombre {
            get => _nombre;
            set { _nombre = value; }
        }
        public Nivel(int numColores, int intentos, string nombre) {
            NumColores = numColores;
            Intentos = intentos;
            Nombre = nombre;
        }
    }
}
