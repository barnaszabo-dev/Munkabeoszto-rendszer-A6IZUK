using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK.KivetelKezeles
{
    public class AlkalmazottKivetelKezeles : SajatKivetelkezeles
    {
        public AlkalmazottKivetelKezeles(Alkalmazott alkalmazott, string uzenet) : base($"A {alkalmazott.DolgozoAzonosito} azonosítóval rendelkező alkalmazottnál: {uzenet}") { }
    }
}
