using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Pila
    {
        private int tope = -1;
        private int tamaño;
        private CD[] listadediscos;

        public Pila (int t)
        {
            tamaño = t;
            listadediscos = new CD[t];
        }

        public void Push (CD c)
        {
            if (tope < tamaño - 1)
            {
                tope += 1;
                listadediscos[tope] = c;
            }
        }

        public CD Pop ()
        {
            tope -= 1;
            return listadediscos[tope + 1];
        }

        public CD Peek()
        {
            return listadediscos[tope];
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
