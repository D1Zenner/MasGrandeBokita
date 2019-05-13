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
            Pila pila2 = new Pila(5);
            Pila pilaAux = new Pila(5);
            PilaAvanzada pila3 = new PilaAvanzada(5);

            CD disco1 = new CD("Groove", "Michael", 20);
            CD disco2 = new CD("Night", "Juan", 5);
            CD disco3 = new CD("Dance", "Rockets", 2);
            CD disco4 = new CD("Party", "Lunatiks", 3);
            CD disco5 = new CD("Fight", "Doom", 3);

            DVD dvd1 = new DVD("Moonlight", "Mashups", 2);

            Cassette cassette1 = new Cassette("Bloody Tears", "Belmonts", 1);


            pila1.Push(disco1);
            pila1.Push(dvd1);
            pila1.Push(disco3);
            pila1.Push(cassette1);
            pila1.Push(disco5);

            while (!pila1.IsEmpty())
            {
                pilaAux.Push(pila1.Pop());
            }

            while (!pilaAux.IsEmpty())
            {
                pila2.Push(pilaAux.Pop());
            }

            while (!pila2.IsEmpty())
            {
                Console.WriteLine(pila2.Pop().Titulo);
            }

            pila3.Push(disco1);
            pila3.Push(dvd1);
            pila3.Push(disco3);
            pila3.Push(cassette1);
            pila3.Push(disco5);

            Console.WriteLine(pila3.Search("Moonlight"));
            Console.WriteLine(pila3.Search("bloody tears")); //En este caso el tema esta con letras mayusculas, por lo tanto deberia devolver false.







            /*
            for (int i = 0; i < pila1.Length; i++)
            {
                Console.WriteLine("discos de pila 1:" + pila1[i]);
            }

            Console.WriteLine("");

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
            */
            Console.ReadKey();
            


        }
    }
}
