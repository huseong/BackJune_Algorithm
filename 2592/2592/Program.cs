using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2592
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] su = new int[10];
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                su[i] = Console.Read();
                sum += su[i];
            }

        }
    }
}
