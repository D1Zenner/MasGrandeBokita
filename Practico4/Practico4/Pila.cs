using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Pila
    {
        public int tope = -1;
        public int tamaño;
        public Medios[] listadetemas;

        public Pila (int t)
        {
            tamaño = t;
            listadetemas = new Medios[t];
        }

        //Metodos
        public void Push (Medios c)
        {
            if (tope < tamaño - 1)
            {
                tope += 1;
                listadetemas[tope] = c;
            }
        }

        public Medios Pop ()
        {
            tope -= 1;
            return listadetemas[tope + 1];
        }

        public Medios Peek()
        {
            return listadetemas[tope];
        }

        public bool IsEmpty()
        {
            if (tope == -1) return true;
            else return false;
        }

        public bool IsFull()
        {
            if (tope + 1 == tamaño) return true;
            else return false;
        }


    }
}
