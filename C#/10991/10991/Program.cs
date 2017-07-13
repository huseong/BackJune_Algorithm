using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10991
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                for (int j = n - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
