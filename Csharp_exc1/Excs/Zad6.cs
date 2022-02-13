using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    class Zad6
    {
        static int i1;
        static int i2;
        public static void zad6_main()
        {
            Console.Write("First number: ");
            i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            i2 = Convert.ToInt32(Console.ReadLine());
            int wynik = i1 + i2;
            Console.WriteLine($"Sum: {i1.ToString()} + {i2.ToString()} = {wynik}");
            wynik = i2 - i2;
            Console.WriteLine($"Extraction: {i1.ToString()} - {i2.ToString()} = {wynik}");
            wynik = i1 * i2;
            Console.WriteLine($"Multipliaction: {i1.ToString()} x {i2.ToString()} = {wynik}");
            wynik = Convert.ToInt32(i1 / i2);
            Console.WriteLine($"Divison (with ints): {i1.ToString()} / {i2.ToString()} = {wynik}");
        }
    }
}
