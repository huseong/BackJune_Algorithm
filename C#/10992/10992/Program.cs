using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10992
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine("*");
            else
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
                for (int i = 1; i < n - 1; i++)
                {
                    for (int j = 1; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write(" ");
                    Console.Write("*");
                    Console.WriteLine();
                }
                for (int i = 0; i < 2 * n - 1; i++)
                    Console.Write("*");
            }
        }
    }
}
