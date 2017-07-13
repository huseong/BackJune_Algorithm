using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1463
{
    class Program
    {
        static int two(uint n)
        {
            int count = 0;
            while (true)
            {
                if (n == 1)
                    break;
                if (n % 2 != 0)
                    return 0;
                
                n /= 2;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int i = 0;
            for(i=0;n>1;i++)
            {
                if (two(n) != 0)
                {
                    i += two(n);
                    break;
                }
                if (n % 3 == 0)
                    n /= 3;
                else if ((n - 1) % 3 == 0)
                    n--;
                else if (n % 2 == 0)
                    n /= 2;
                else
                    n--;
            }
            Console.Write(i);
        }
    }
}
