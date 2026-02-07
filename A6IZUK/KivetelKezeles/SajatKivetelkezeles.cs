using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK.KivetelKezeles
{
    public class SajatKivetelkezeles : Exception
    {
        public SajatKivetelkezeles(string uzenet): base($"Saját osztályon belüli kivételkezelés\n--{uzenet}") { }
    }
}
