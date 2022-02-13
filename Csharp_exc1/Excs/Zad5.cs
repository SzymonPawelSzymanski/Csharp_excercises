using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    class Zad5
    {
        static int i1;
        static int i2;
        static int i3;

        public static void zad5_main()
        {
            Console.Write("First number: ");
            i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number: ");
            i3 = Convert.ToInt32(Console.ReadLine());
            int wynik = i1 * i2 * i3;
            Console.WriteLine($"Result of this multipliaction: {i1.ToString()} x {i2.ToString()} x {i3.ToString()} = {wynik}" );
        }
    }
}
