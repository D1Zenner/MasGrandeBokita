using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class PilaAvanzada : Pila
    {

        public PilaAvanzada(int t) : base(t)
        {
        }

        //Metodo
        public bool Search(string titulo)
        {
            int flag = 0;
            for (int i = 0; i<listadetemas.Length;i++)
            {
                if(titulo==listadetemas[i].Titulo)
                {
                    flag = 1;
                }
            }
            if (flag == 1) return true;
            else return false;
            
        }
         

    }
}
