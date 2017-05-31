using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] count = new int[n];
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            for(int i=0; i<n; i++)
            {
                count[i] = int.Parse(a[i]);
            }
            for(int i=n-1; i>=0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if(count[j]>count[j+1])
                    {
                        int temp = count[j];
                        count[j] = count[j + 1];
                        count[j + 1] = temp;
                    }
                }
            }
            Console.Write(count[0] * count[count.Length - 1]);
        }
    }
}
