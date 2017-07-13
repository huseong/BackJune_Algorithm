using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9498
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch(n/10)
            {
                case 10:
                case 9: Console.Write("A"); break;
                case 8: Console.Write("B"); break;
                case 7: Console.Write("C"); break;
                case 6: Console.Write("D"); break;
                default: Console.Write("F"); break;
            }
        }
    }
}
