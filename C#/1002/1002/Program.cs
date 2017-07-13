using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    class Program
    {
        static double huseong(string a, string b, string c, string d)
        {
            return Math.Sqrt((int.Parse(a) - int.Parse(b)) * (int.Parse(a) - int.Parse(b)) + (int.Parse(c) - int.Parse(d)) * (int.Parse(c) - int.Parse(d)));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0; i<n; i++)
            {
                string[] b=Console.ReadLine().Split(new char[] { ' ' });
                if  (huseong(b[0], b[3], b[1], b[4]) > int.Parse(b[2])+int.Parse(b[5]))
                {
                    a[i] = 0;
                }
                else if (huseong(b[0], b[3], b[1], b[4]) == int.Parse(b[2]) + int.Parse(b[5]))
                {
                    a[i] = 1;
                }
                else if (huseong(b[0], b[3], b[1], b[4]) < int.Parse(b[2]) + int.Parse(b[5]))
                {
                    if((b[0]==b[3]&&b[1]==b[4])&&(b[2]==b[5]))
                    {
                        a[i] = -1;
                    }
                    else if (huseong(b[0], b[3], b[1], b[4]) < Math.Abs(int.Parse(b[2]) - int.Parse(b[5])))
                    {
                        a[i] = 0;
                    }
                    else if (huseong(b[0], b[3], b[1], b[4]) == Math.Abs(int.Parse(b[2]) - int.Parse(b[5])))
                    {
                        a[i] = 1;
                    }
                    else
                    {
                        a[i] = 2;
                    }
                }
            }
            for (int i= 0; i<n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
