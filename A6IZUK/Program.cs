using A6IZUK.KivetelKezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var alkalmazottKezelo = new AlkalmazottKezelo();
                alkalmazottKezelo.MunkaCsoportMegszunese += (string uzenet) => { Console.WriteLine($"{uzenet}\n"); };
                alkalmazottKezelo.BeszurasUjAlkalmazottUjMunkaCsoport(new List<Alkalmazott>() {
               
                new Alkalmazott("HagymaEvo Aladar", 'F', new List<FeladatKor>() { new FeladatKor("WC-tisztito", 4) }, 500000),
                new Alkalmazott("Ceklakopo Eva", 'N', new List<FeladatKor>() { new FeladatKor("Zuhanyzo-tisztito", 4) }, 700000),
                new Alkalmazott("Zellerrezelo Bela", 'F', new List<FeladatKor>() { new FeladatKor("Folyosok-tisztito", 4) }, 600000)
            }, new MunkaCsoport("Tisztítók", 10));

                alkalmazottKezelo.BeszurasUjAlkalmazottUjMunkaCsoport(

                new List<Alkalmazott>() {
                 new Alkalmazott("HMarika", 'N', new List<FeladatKor>() { new FeladatKor("Tortenelemtanar", 2) }, 100000),
                 new Alkalmazott("Katailin", 'N', new List<FeladatKor>() { new FeladatKor("Biologiatanar", 8) }, 5000),
                 new Alkalmazott("Krisztina", 'N', new List<FeladatKor>() { new FeladatKor("Fizikatanar",8) }, 7000)
                }, new MunkaCsoport("Tanitok", 10));

                alkalmazottKezelo.TorlesAlkalmazott(alkalmazottKezelo.AdottIndexuMunkaCsoport(0).AdottIndexuDolgozo(0));
                alkalmazottKezelo.TorlesAlkalmazott(alkalmazottKezelo.AdottIndexuMunkaCsoport(0).AdottIndexuDolgozo(0));
                alkalmazottKezelo.TorlesAlkalmazott(alkalmazottKezelo.AdottIndexuMunkaCsoport(0).AdottIndexuDolgozo(0));
                alkalmazottKezelo.HozzaadasOraAlkalmazott(alkalmazottKezelo.AdottIndexuMunkaCsoport(0).AdottIndexuDolgozo(0), 1);

            }
            catch(SajatKivetelkezeles e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Mivel ez súlyos hiba, véget ért a program működése!");
                Environment.Exit(1);
            }


              

         
                

            Console.ReadKey();
        }
    }
}

