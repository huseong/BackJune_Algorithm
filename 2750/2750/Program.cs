using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2750
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] na = new int[n];
            for(int i=0; i<n; i++)
            {
                na[i] = int.Parse(Console.ReadLine());
            }
            for(int i=n-1; i>=0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if(na[j]>na[j+1])
                    {
                        int temp = na[j];
                        na[j] = na[j + 1];
                        na[j + 1] = temp;
                    }
                }
            }
            foreach(var item in na)
            {
                Console.WriteLine(item);
            }
        }

    }
}
