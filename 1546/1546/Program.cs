using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1546
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] scan = Console.ReadLine().Split(new char[] { ' ' });
            int maxValue = 0;
            double sum = 0;
            for(int i=0; i<n; i++)
            {
                if (int.Parse(scan[i]) > maxValue)
                    maxValue = int.Parse(scan[i]);
            }
            for(int i=0; i<n; i++)
            {
                sum += int.Parse(scan[i]) / (double)maxValue * 100.0;
            }
            Console.Write((sum / (double)n).ToString("0.00"));
        }
    }
}
