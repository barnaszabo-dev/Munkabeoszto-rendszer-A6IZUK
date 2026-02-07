using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK.KivetelKezeles
{
    public class AlkalmazottKezeloKivetelKezeles : SajatKivetelkezeles
    {
        public AlkalmazottKezeloKivetelKezeles(string uzenet): base($"Alkalmazott kezelőnél: {uzenet}") { }
     
    }
}
