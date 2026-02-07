using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public abstract class Ember
    {
        public char Nem { get; private set; }
        public int TeherBirasHatar { get; private set; }

        public Ember(char nem) 
        {
            TeherBirasHatar = new Random().Next(4, 13);
            this.Nem = nem;
        }
        
    }
}
