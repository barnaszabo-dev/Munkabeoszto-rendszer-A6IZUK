using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public class FeladatKor
    {
        public string Megnevezes { get; private set; }

        public int Munkaido { get; private set; }

        public FeladatKor(string megnevezes, int munkaido)
        {
            Megnevezes = megnevezes;
            Munkaido = munkaido;
        }
    }
}
