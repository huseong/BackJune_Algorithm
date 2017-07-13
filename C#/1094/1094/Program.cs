using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int stick = int.Parse(Console.ReadLine());
            int cut = 64;
            int count = 0;
            for(int i=32; i>1; i/=2)
            {
                count++;
                if(cut>stick)
                {
                    if(cut-i>stick)
                    {
                        cut -= i;
                    }
                    else if()
                }
                else
                {
                    break;
                }
            }
            Console.Write(count);
        }
    }
}
