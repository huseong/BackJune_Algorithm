using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11721
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int length = a.Length;
            for(int i=1; i<=a.Length; i++)
            {
                
                Console.Write(a[i-1]);
                if (i % 10 == 0)
                    Console.Write("\n");
            }
        }
    }
}
