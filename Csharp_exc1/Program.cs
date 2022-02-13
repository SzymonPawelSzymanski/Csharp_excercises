using System;
using Csharp_exc1.Excs;

namespace Csharp_exc1
{
    class Program
    {
        static bool exit = true;
        static void Main()
        {
            while (exit)
            {
                Zad7.zad7_main();
                ifExit();
            }
            Environment.Exit(0);
        }

        static void ifExit()
        {
            Console.WriteLine("Czy chcesz kontynuować działanie programu? (y/n): ");
            char odp = Convert.ToChar(Console.ReadLine());
            if(odp == 'n')
            {
                exit = false;
            }
        }
    }
}
