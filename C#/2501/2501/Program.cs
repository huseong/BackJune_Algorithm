using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2501
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            int n = int.Parse(a[0]);
            int k = int.Parse(a[1]);
            List<int> list = new List<int>();
            list.Add(1);
            for(int i=2; i<n; i++)
            {
                if(n%i==0)
                {
                    if (list.Contains(i))
                    {
                        break;
                    }
                    if(i*i!=n)
                    {
                        list.Add(n / i);
                    }
                    list.Add(i);
                }
            }
            for(int i=list.Count-1; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if(list[j]>list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            list.Add(n);
            if (k > list.Count)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write(list[k - 1]);
            }
        }
    }
}
