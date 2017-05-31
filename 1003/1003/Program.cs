using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003
{
    class Program
    {
        static int count0;
        static int count1;
        static void fibo(int a)
        {
            if (a == 0)
            {
                count0++;
            }
            else if (a == 1)
            {
                count1++;
            }
            else
            {
                fibo(a - 2); fibo(a - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> count00=new List<int>();
            List<int> count11 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                count0 = 0;
                count1 = 0;
                fibo(d);
                count00.Add(count0);
                count11.Add(count1);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(count00[i] + " " + count11[i]);
            }
        }
    }
}
