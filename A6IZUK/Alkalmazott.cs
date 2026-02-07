using A6IZUK.KivetelKezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public sealed class Alkalmazott : Ember, IMunkaraAlkalmas
    {
        public event AlkalmazottEltavolitasa NemAlkalmazhatoTobbet;
        public string Nev { get; private set; }

        public string DolgozoAzonosito { get; private set; }
        public List<FeladatKor> FeladatKorok { get; private set; }

        public int MunkaOra { get; private set; }

        public int OraDij { get; private set; }


        public Alkalmazott(string nev, char nem, List<FeladatKor> feladatKorok, int oraDij) : base(nem)
        {
            Nev = nev;
            foreach (FeladatKor feladatkor in feladatKorok) Terheles(feladatkor.Munkaido);
            FeladatKorok = feladatKorok;
            OraDij = oraDij;
        }

        public void FeladatkorHozzaadasa(FeladatKor feladatKor)
        {
            Terheles(feladatKor.Munkaido);
            this.FeladatKorok.Add(feladatKor);
        }

        public void AzonositoMegadasa(string ID)
        {
            this.DolgozoAzonosito = ID;
        }


        public int MunkaDij(int oraszam)
        {
            return oraszam * this.OraDij;
        }

        public void Terheles(int munkaOra)
        {
            if (!(this.TeherBirasHatar < this.MunkaOra)) this.MunkaOra += munkaOra;
            else throw new AlkalmazottKivetelKezeles(this, "Nem lehet ennél többet terhelni");
        }

        public double TeherBiras()
        {
            return this.MunkaOra / this.TeherBirasHatar;
        }

        public bool TerheletoMeg()
        {
            bool megE = this.TeherBirasHatar < this.MunkaOra;
            if (megE) NemAlkalmazhatoTobbet.Invoke(this); 
            return megE;
        }
    }
}
