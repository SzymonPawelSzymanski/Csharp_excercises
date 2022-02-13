using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exc1.Excs
{
    class Zad2
    {
        //basic calculator for two integers 
        static char op;
        static int i1;
        static int i2;
        static string dzialanie;
        static string[] podzielone;
        static int wynikint;
        static float wynikfloat;
        public static void zad2_main()
        {
            Console.WriteLine("Wprowadz swoje dzialanie w formie: pierwsza_liczba operator druga_liczba, np: 10 * 12");
            dzialanie = Console.ReadLine();
            podzielone = dzialanie.Split(" ", StringSplitOptions.None);
            //Console.WriteLine(podzielone[0] + podzielone[1] + podzielone[2]);
            op = Convert.ToChar(podzielone[1]);
            i1 = Convert.ToInt32(podzielone[0]);
            i2 = Convert.ToInt32(podzielone[2]);
            wynikint = SwitchChar(op, wynikint, i1, i2);
            Console.WriteLine("Wynik twojego dzialania to " + wynikint.ToString() + ".");
        }

        static int SwitchChar(char op, int wynikint, int i1, int i2)
        {
            switch(op)
            {
                    case '+':
                        {
                            wynikint = i1 + i2;
                            return wynikint;
                        }
                    case '-':
                        {
                            wynikint = i1 - i2;
                            return wynikint;
                        }
                    case '*':
                        {
                            wynikint = i1 * i2;
                            return wynikint;
                        }
                    case '%':
                        {
                            wynikint = i1 % i2;
                            return wynikint;
                        }
                    default: return 0;
            }
        }
    }
}
