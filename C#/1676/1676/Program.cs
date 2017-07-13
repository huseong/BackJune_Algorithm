using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1676
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int kaka = 1;
            int count = 0;
            for(int i=2; i<=n; i++)
            {
                kaka *= i;
                if(kaka.ToString().Length>6)
                {
                    kaka %= 100000;
                }
                while(kaka%10==0)
                {
                    kaka /= 10;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
