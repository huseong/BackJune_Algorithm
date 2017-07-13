using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while(true)
            {
                string[] a = Console.ReadLine().Split(new char[] { ' ' });
                if (a[0] == "0" && a[1] == "0")
                    break;
                list.Add(int.Parse(a[0]) + int.Parse(a[1]));
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
