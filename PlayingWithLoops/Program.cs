using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Użycie pętli for:");

            for (int a = 100; a > 0; a--)
            {
                if (a % 3 == 0 && a % 2 != 0)
                {
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine("Użycie pętli while:");

            int b = 100;
            while (b > 0)
            {
                if (b % 3 == 0 && b % 2 != 0)
                {
                    Console.WriteLine(b);
                }
                b--;
            }

            Console.WriteLine("Użycie pętli do while:");

            int c = 100;
            do
            {
                if (c % 3 == 0 && c % 2 != 0)
                {
                    Console.WriteLine(c);
                }
                c--;
            } while (c > 0);

            Console.ReadKey();
        }
    }
}
