using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK
{
    public interface IMunkaraAlkalmas
    {
        string Nev { get; }
        string DolgozoAzonosito { get; }

        int MunkaDij(int oraszam);

        void Terheles(int munkaOra);

        double TeherBiras();

        bool TerheletoMeg();

        List<FeladatKor> FeladatKorok { get; }

    }

}
