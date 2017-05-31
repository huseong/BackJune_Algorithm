using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10817
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            int[] b = new int[3];
            for(int i=0; i<3; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            for(int i=2; i>=0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (b[j] > b[j+1])
                    {
                        int temp = b[j];
                        b[j] = b[j+1];
                        b[j+1] = temp;
                    }
                }
            }
            Console.Write(b[1]);
        }
    }
}
