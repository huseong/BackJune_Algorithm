using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<StringBuilder> list = new List<StringBuilder>();
            for(int i=0; i<n; i++)
            {
                StringBuilder stb = new StringBuilder();
                string[] a=Console.ReadLine().Split(new char[] {' ' });
                int na = int.Parse(a[0]);
                string ba = a[1];
                for(int j=0; j<ba.Length; j++)
                {
                    for (int k = 0; k < na; k++)
                    {
                        stb.Append(ba[j]);
                    }
                }
                list.Add(stb);
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
