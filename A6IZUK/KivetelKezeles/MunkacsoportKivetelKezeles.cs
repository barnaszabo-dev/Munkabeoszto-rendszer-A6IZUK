using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK.KivetelKezeles
{
    public class MunkacsoportKivetelKezeles : SajatKivetelkezeles
    {
        public MunkacsoportKivetelKezeles(MunkaCsoport munkacsoport, string uzenet) : base($"A {munkacsoport.Nev} nevű munkacsoportnál: {uzenet}") { } 
    }
}
