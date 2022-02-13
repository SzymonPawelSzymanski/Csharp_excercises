using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    class Zad4
    {
        static int a;//3
        static int b;//5

        public static void zad4_main() 
        {
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;// a = 8; b = 5
            b = a - b; // b = 3; a = 8
            a = a - b; // a = 5; b = 3;

            Console.WriteLine("Swapped nubers - A =  " + a.ToString() + " B = " + b.ToString());
        }
    }
}
