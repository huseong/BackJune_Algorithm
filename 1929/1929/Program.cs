using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            int min = int.Parse(a[0]);
            int max = int.Parse(a[1]);
            List<int> list = new List<int>();
            bool T = false;
            int listLength = 1;
            list.Add(2);
            for(int i=3; i<=max; i++)
            {
                T = true;
                double u = Math.Sqrt(i);
                for(int j=0; list[j]<=u; j++)
                {
                    if(i%list[j]==0)
                    {
                        T = false;
                        break;
                    }
                }
                if(T)
                {
                    list.Add(i);
                    listLength++;
                }
            }
            foreach(var item in list)
            {
                if (item < min)
                    continue;
                Console.Write(item + "\n");
            }
        }
    }
}
