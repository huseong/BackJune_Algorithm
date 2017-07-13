using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11653
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
            }
            else
            {
                for (int i = 2; ;)
                {
                    if (n % i == 0)
                    {
                        n /= i;
                        Console.Write(i + "\n");
                        if (n == 1)
                            break;
                        i = 2;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
