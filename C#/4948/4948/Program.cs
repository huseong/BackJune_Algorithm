using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4948
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            int max = 0;
            for(; ;)
            {
                int n = int.Parse(Console.ReadLine());
                if(n>max)
                {
                    max = n;
                }
                if(n==0)
                {
                    break;
                }
                a.Add(n);
            }
            List<int> list = new List<int>();
            list.Add(2);
            for (int i = 3; i <= 2 * max; i++)
            {
                 bool boo = true;
                 for (int j = 0; list[j] <= Math.Sqrt(i); j++)
                 {
                     if (i % list[j] == 0)
                     {
                         boo = false;
                         break;
                     }
                 }
                 if (boo)
                 {
                     list.Add(i);
                 }
            }
            int length = list.Count;
            for(int i=0; i<a.Count; i++)
            {
                int count = 0;
                for (int j = 0; j<length;j++)
                {
                    if(list[j]<=a[i])
                    {
                        continue;
                    }
                    else if(list[j]>a[i]*2)
                    {
                        break;
                    }
                    count++;
                }
                Console.Write(count + "\n");
            }
        }
    }
}
