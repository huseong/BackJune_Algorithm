using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int counter = 1;
            while(true)
            {
                if(n<=i)
                {
                    break;
                }
                else
                {
                    i += ++counter;
                }
            }
            if (counter%2==0)
            {
                Console.Write((counter + 1 - (i - n + 1)) + "/" + (i - n + 1 % counter));
            }
            else
            {
                Console.Write((i-n) % counter+1 + "/" + (counter+1-(i-n+1)));
            }
        }
    }
}
