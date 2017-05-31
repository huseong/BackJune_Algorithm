using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004
{
    class Program
    {
        static double huseong(int a, int b, int c, int d)
        {
            return Math.Sqrt((a - b) * (a - b) + (c - d) * (c - d));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] count_s = new int[n];
            for (int i = 0; i < n; i++)
            {
                count_s[i] = 0;
                string[] scan = Console.ReadLine().Split(new char[] { ' ' });
                int hangsung = int.Parse(Console.ReadLine());
                for (int j = 0; j < hangsung; j++)
                {
                    string[] S_t = Console.ReadLine().Split(new char[] {' '});
                    if (huseong(Convert.ToInt32(scan[0]), Convert.ToInt32(S_t[0]), Convert.ToInt32(scan[1]), Convert.ToInt32(S_t[1])) < Convert.ToInt32(S_t[2]))
                    {
                        if (huseong(Convert.ToInt32(scan[2]), Convert.ToInt32(S_t[0]), Convert.ToInt32(scan[3]), Convert.ToInt32(S_t[1])) > Convert.ToInt32(S_t[2]))
                        {
                            count_s[i]++;
                        }
                    }
                    else if(huseong(Convert.ToInt32(scan[2]), Convert.ToInt32(S_t[0]), Convert.ToInt32(scan[3]), Convert.ToInt32(S_t[1])) < Convert.ToInt32(S_t[2]))
                    {
                        if(huseong(Convert.ToInt32(scan[0]), Convert.ToInt32(S_t[0]), Convert.ToInt32(scan[1]), Convert.ToInt32(S_t[1])) > Convert.ToInt32(S_t[2]))
                        {
                            count_s[i]++;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            { Console.WriteLine(count_s[i]); }
        }
    }
}
