using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    static class Zad3
    {
        static DataTable dt = new DataTable();
        public static void zad3_main()
        {
            var wynik = dt.Compute("2 + 3 * (2+4)", " ");
            Console.WriteLine(wynik.ToString());
        }
    }
}
