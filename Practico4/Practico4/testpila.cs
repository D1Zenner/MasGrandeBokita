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
            string[] pila1 = new string[5] { "disco1", "disco2", "disco3", "disco4", "disco5" };
            string[] pila2 = new string[5];

            Console.WriteLine("");

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
          
            Console.ReadKey();
        }
    }
}
