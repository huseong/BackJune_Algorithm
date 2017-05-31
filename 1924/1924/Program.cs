using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1924
{
    class Program
    {
        static public int Month(int m)
        {
            switch(m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: return 31;
                case 2: return 28;
                case 4:
                case 6:
                case 9:
                case 11: return 30;
                default: return 0;
            }
        }



        static void Main(string[] args)
        {
            String[] a = Console.ReadLine().Split(new char[] { ' ' });
            int d = 0;
            for(int i=1; i<int.Parse(a[0]); i++)
            {
                d += Month(i);
            }
            d += int.Parse(a[1]);
            d -= 1;
            switch(d%7)
            {
                case 0:Console.Write("MON");
                    break;
                case 1:
                    Console.Write("TUE");
                    break;
                case 2:
                    Console.Write("WED");
                    break;
                case 3:
                    Console.Write("THU");
                    break;
                case 4:
                    Console.Write("FRI");
                    break;
                case 5:
                    Console.Write("SAT");
                    break;
                case 6:
                    Console.Write("SUN");
                    break;

         
            }
        }
    }
}
