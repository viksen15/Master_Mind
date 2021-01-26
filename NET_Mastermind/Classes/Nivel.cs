using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Mastermind {
    class Nivel {
        private int _numColores;
        private int _intentos;
        public int NumColores {
            get => _numColores;
            set { _numColores = value; }
        }
        public int Intentos {
            get => _intentos;
            set { _intentos = value; }
        }
        public Nivel(int numColores, int intentos) {
            NumColores = numColores;
            Intentos = intentos;
        }
    }
}
