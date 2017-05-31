using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4344
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] avg = new double[n];
            double[] hap = new double[n];
            for(int i=0; i<n; i++)
            {
                string[] scan = Console.ReadLine().Split(new char[] { ' ' });
                int count = 0;
                for(int j=1; j<scan.Length; j++)
                {
                    count += int.Parse(scan[j]);
                }
                avg[i] = (double)count / int.Parse(scan[0]);
                count = 0;
                for(int j=1; j<scan.Length; j++)
                {
                    if(avg[i]<int.Parse(scan[j]))
                    {
                        count++;
                    }
                }
                hap[i] = (double)count /int.Parse(scan[0]);
            }
            foreach(var item in hap)
            {
                Console.WriteLine("{0:F3}"+"%", item*100);
            }
        }
    }
}
