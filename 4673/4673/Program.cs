using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4673
{
    class Program
    {
        static public int leesin(int a)
        {
            return a + a / 1000 + (a - a / 1000 * 1000) / 100 + (a - a / 100 * 100) / 10 + (a - a / 10 * 10);
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i=1; i<=10000; i++)
            {
                list.Add(i);
            }
            for(int i=1; i<=10000; i++)
            {
                list.Remove(leesin(i));
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
