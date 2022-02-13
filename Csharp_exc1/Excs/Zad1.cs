using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    public class Zad1
    {
        //prints strings from the input basically
        static string name_sur;
        public static void zad1_main()
        {
            Console.WriteLine("Wprowadz swoje imie i nazwisko: ");
            name_sur = Console.ReadLine();
            Console.WriteLine("Twoje imie i nazwisko to " + name_sur);
        }


    }
}
