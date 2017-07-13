using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2444
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i + 1) * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for(int i=1; i<n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<2*(n-1)-2*(i-1)-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
