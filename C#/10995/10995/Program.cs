using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10995
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                if(i%2==0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(" *");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
