using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11022
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] countA = new int[n];
            int[] countB = new int[n];
            for(int i=0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split(new char[] { ' ' });
                countA[i] = int.Parse(a[0]);
                countB[i] = int.Parse(a[1]);
            }
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Case #" + i + ": " + countA[i-1] + " + " + countB[i-1] + " = " + (countA[i-1]+countB[i-1]));
            }
        }
    }
}
