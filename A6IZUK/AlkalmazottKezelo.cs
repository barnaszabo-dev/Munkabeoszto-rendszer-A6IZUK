using A6IZUK.KivetelKezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public class AlkalmazottKezelo
    {
        public event MegszunesJelzese MunkaCsoportMegszunese;
        public RendezettLancoltLista<MunkaCsoport, int> Munkacsoportok { get; private set; } = new RendezettLancoltLista<MunkaCsoport, int>();

        public void BeszurasUjAlkalmazottUjMunkaCsoport(List<Alkalmazott> alkalmazottak, MunkaCsoport munkaCsoport)
        {
            foreach (var alkalmazott in alkalmazottak)
            {
                alkalmazott.AzonositoMegadasa(GeneralasID(alkalmazott.Nem));
                alkalmazott.NemAlkalmazhatoTobbet += TorlesAlkalmazott;
                munkaCsoport.Hozzaad(alkalmazott);
            }
            this.BeszurasMunkacsoport(munkaCsoport);
        }

        public void BeszurasUjAlkalmazott(Alkalmazott alkalmazott, MunkaCsoport munkaCsoport)
        {
            alkalmazott.AzonositoMegadasa(GeneralasID(alkalmazott.Nem));
            this.Munkacsoportok.GetReferencia(munkaCsoport).Hozzaad(alkalmazott);

        }
        public void BeszurasMunkacsoport(MunkaCsoport munkacsoport)
        {
            if(munkacsoport.Letszam != 0) this.Munkacsoportok.Beszuras(munkacsoport, int.Parse(munkacsoport.GetElsoEmber().DolgozoAzonosito.Remove(0, 2).Remove(3, 2)));
            else throw new AlkalmazottKezeloKivetelKezeles("Nem lehet beszúrni 0 fős munkacsoportot");


        }

        public void HozzaadasOraAlkalmazott(Alkalmazott alkalmazott, int ora)
        {
            foreach (MunkaCsoport munkacsoport in Munkacsoportok)
            {
                if (munkacsoport.BenneVanEAlkalmazott(alkalmazott))
                {
                    alkalmazott.Terheles(ora);
                }
            }
        }
        public MunkaCsoport AdottIndexuMunkaCsoport(int index)
        {
            if(this.Munkacsoportok.Count > index) return Munkacsoportok.GetItemByIndex(index);
            throw new AlkalmazottKezeloKivetelKezeles("Túlindexelés!");


        }

        public Alkalmazott getAlkalmazottByIndex(int index, MunkaCsoport munkaCsoport)
        {
            if(Munkacsoportok.BenneVanE(munkaCsoport))
            {
                return Munkacsoportok.GetReferencia(munkaCsoport).AdottIndexuDolgozo(index);
            }
            throw new AlkalmazottKezeloKivetelKezeles("Nincs ilyen munkacsoport");   

        }


        public void TorlesAlkalmazott(Alkalmazott alkalmazott)
        {
            foreach (MunkaCsoport munkacsoport in Munkacsoportok)
            {
                if(munkacsoport.BenneVanEAlkalmazott(alkalmazott))
                {
                    munkacsoport.Torles(alkalmazott);
                    if(munkacsoport.Letszam == 0)
                    {
                        Munkacsoportok.Torles(munkacsoport);
                        MunkaCsoportMegszunese.Invoke($"A(z) {munkacsoport.Nev} nevű munkacsoport megszűnt!");
                    }
                }
            }
        }



        private string GeneralasID(char nem)
        {
            Random random = new Random();


            const int offset = 65; // ASCII code for 'A'
            const int numberOfBigChars = 26; // Total number of capital letters

            int randomNumberForCharacters1 = random.Next(numberOfBigChars);
            int randomNumberForCharacters2 = random.Next(numberOfBigChars);
            char randomBigChar1 = (char)(offset + randomNumberForCharacters1);
            char randomBigChar2 = (char)(offset + randomNumberForCharacters2);

            int randomNumberForNumbers = random.Next(100,1000);

            return $"{nem}-{randomNumberForNumbers}{randomBigChar1}{randomBigChar2}";
        }
     

    }
}
