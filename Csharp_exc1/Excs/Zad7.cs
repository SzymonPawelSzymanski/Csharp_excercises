using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    class Zad7
    {
        static int i1;
        public static void zad7_main() 
        {
            Console.WriteLine("Input number: ");
            i1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++) 
            {
                Console.WriteLine($"{i1} * {i} = {i1*i}");
            }
        }
    }
}
