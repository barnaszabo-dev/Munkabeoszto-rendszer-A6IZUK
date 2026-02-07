using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A6IZUK
{
    public class RendezettLancoltLista<T, K> :IEnumerable where K : IComparable<K>
    {
        public int Count { get; private set; } = 0;


        ListaElem _fej;

        
        class ListaBejaro : IEnumerator
        {
            ListaElem fej;
            ListaElem aktualis;

            public ListaBejaro(ListaElem fej)
            {
                this.fej = fej;
                this.aktualis = new ListaElem();
                this.aktualis.kovetkezo = fej;
            }
            public object Current { get { return aktualis.tartalom; } }

            public bool MoveNext()
            {
                aktualis = aktualis.kovetkezo;
                return aktualis != null;
            }

            public void Reset()
            {
                aktualis = new ListaElem();
                aktualis.kovetkezo = fej;
            }
        }
        private class ListaElem
        {
            public K kulcs;
            public T tartalom;
            public ListaElem kovetkezo;
            public ListaElem(T tartalom, K kulcs)
            {
                this.kulcs = kulcs;
                this.tartalom = tartalom;
                kovetkezo = null;
            }
            public ListaElem()
            {

            }
        }

        public IEnumerator GetEnumerator() 
        { 
            return new ListaBejaro(_fej);
        }

        public T GetReferencia(T tartalom)
        {            
            ListaElem aktualis = _fej;
            while (!tartalom.Equals(aktualis.tartalom))
            {
                aktualis = aktualis.kovetkezo;
            }
            return aktualis.tartalom;
            
        }

        public T GetItemByIndex(int index)
        {
            ListaElem aktualis = _fej;         
            for (int i = 0; i < index; i++)
            {
                aktualis = aktualis.kovetkezo;
            }
            return aktualis.tartalom;
        }

        public bool BenneVanE(T tartalom)
        {
            ListaElem aktualis = _fej;

            if (_fej == null) return false;

            while (!tartalom.Equals(aktualis.tartalom))
            {
                if( aktualis.kovetkezo == null) return false;
                aktualis = aktualis.kovetkezo;
            }
            return true;

        }

        public void Beszuras(T ujTartalom, K ujKulcs)
        {

            ListaElem ujElem = new ListaElem(ujTartalom, ujKulcs);

            if (_fej == null)
            {
                _fej = ujElem;
            }
            else
            {
                ListaElem aktualis = _fej;
                while (ujKulcs.CompareTo(aktualis.kulcs) > 0)
                {
                    aktualis = aktualis.kovetkezo;
                }
                ujElem.kovetkezo = aktualis.kovetkezo;
                aktualis.kovetkezo = ujElem;
            }
            this.Count++;
        }

        public void Torles(T tartalom)
        {
            
            ListaElem aktualis = _fej;
            ListaElem elozo = null;
            while (!tartalom.Equals(aktualis.tartalom))
            {
                elozo = aktualis;
                aktualis = aktualis.kovetkezo;
            }
            if(elozo == null)
            {
                _fej = aktualis.kovetkezo;
            }
            else
            {
                elozo.kovetkezo = aktualis.kovetkezo;

            }
            this.Count--;
        }

        public T getElsoElem()
        {
            return _fej.tartalom;
        }
    }
}
