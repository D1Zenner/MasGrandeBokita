using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class testpila
    {
        static void Main(string[] args)
        {
            /*
            string[] pila1 = new string[5];
            string[] pila2 = new string[5];
            */

            Pila pila1 = new Pila(5);

            CD disco1 = new CD("Groove", "Michael", 20);
            CD disco2 = new CD("Night", "Juan", 5);
            CD disco3 = new CD("Dance", "Rockets", 2);
            CD disco4 = new CD("Party", "Lunatiks", 3);
            CD disco5 = new CD("Fight", "Doom", 3);

            pila1.Push(disco1);
            pila1.Push(disco2);
            pila1.Push(disco3);
            pila1.Push(disco4);
            pila1.Push(disco5);

            Console.WriteLine("");

            for (int i = 0; i < pila1.; i++)
            {
                Console.WriteLine("discos de pila 1:" + pila1[i]);
            }

            Console.WriteLine("");

            /*
            pila1.CopyTo(pila2, 0);
            for (int i = 0; i < pila2.Length; i++)
            {
                Console.WriteLine("discos de pila 2:" + pila2[i]);
                pila1[i] = null;
            }

            Console.WriteLine("");

            for (int i = 0; i < pila1.Length; i++)
            {
                Console.WriteLine("discos de pila 1:" + pila1[i]);
            }
          
            Console.ReadKey();
            */


        }
    }
}
