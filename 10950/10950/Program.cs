using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] count = new int[n];
            for(int i=0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split(new char[] { ' ' });
                count[i] = int.Parse(a[0]) + int.Parse(a[1]);
            }
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
    }
}
