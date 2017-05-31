using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static bool hansu(int a)
        {
            int back =a / 100;
            int sip = (a - a / 100 * 100)/10;
            int ill = a - a/ 10 * 10;
            if (back - sip == sip - ill)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            if(n<100)
            {
                Console.Write(n);
            }
            else
            {
                for(int i=111; i<=n; i++)
                {
                    if(hansu(i))
                    {
                        count++;
                    }
                }
                Console.Write(count + 99);
            }
        }
    }
}
