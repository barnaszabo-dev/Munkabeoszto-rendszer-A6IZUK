using A6IZUK.KivetelKezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public class MunkaCsoport
    {

        public string Nev { get; private set; }
        public int MaxDolgozokLetszama { get; private set; }

        private RendezettLancoltLista<Alkalmazott, int> alkalmazottak = new RendezettLancoltLista<Alkalmazott, int>();

        public int Letszam { get { return alkalmazottak.Count; }}

        public MunkaCsoport(string nev, int max)
        {
            Nev = nev;
            MaxDolgozokLetszama = max;
        }

        public MunkaCsoport(string nev, int max, RendezettLancoltLista<Alkalmazott, int> alkalmazottak_) 
        {
            Nev = nev;
            MaxDolgozokLetszama = max;
            alkalmazottak = alkalmazottak_;
        }

        public IMunkaraAlkalmas GetElsoEmber()
        {
            if(alkalmazottak.Count > 0) return alkalmazottak.getElsoElem();
            throw new Exception("Nincs alkalmazott");
        }

        public void Hozzaad(Alkalmazott alkalmazott)
        {
            alkalmazott.NemAlkalmazhatoTobbet += Torles;
            if(!(alkalmazottak.Count > MaxDolgozokLetszama))
            {
                alkalmazottak.Beszuras(alkalmazott, int.Parse(alkalmazott.DolgozoAzonosito.Remove(0, 2).Remove(3,2)));
            }
            else throw new MunkacsoportKivetelKezeles(this,"Betelt a hely");
        }

        

        public bool BenneVanEAlkalmazott(Alkalmazott alkalmazott)
        {
            return alkalmazottak.BenneVanE(alkalmazott);
        }

        public Alkalmazott AdottIndexuDolgozo(int index)
        {
            if (this.alkalmazottak.Count > index) return alkalmazottak.GetItemByIndex(index);
            else throw new MunkacsoportKivetelKezeles(this, "Túlindexelés!");
           
        }

        public void Torles(Alkalmazott alkalmazott)
        {
            if (alkalmazottak.Count > 0)
            {
                alkalmazottak.Torles(alkalmazott);
            }
            else throw new MunkacsoportKivetelKezeles(this,"Nincs alkalmazott");


        }
    }
}
