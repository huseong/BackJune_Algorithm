using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2445
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                for (int j = n-1; j > i; j--)
                    Console.Write("  ");
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = n-1; j > i; j--)
                    Console.Write("*");
                for (int j = 0; j <= i; j++)
                    Console.Write("  ");
                for (int j = n - 1; j > i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
