using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6502
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> list = new List<bool>();
            while(true)
            {
                string[] a = Console.ReadLine().Split(new char[] { ' ' });
                int girum = int.Parse(a[0]);
                if (girum == 0)
                    break;
                int garo = int.Parse(a[1]);
                int sero = int.Parse(a[2]);
                list.Add(4 * girum * girum >= garo * garo + sero * sero);
            }
            int i = 1;
            foreach(var item in list)
            {
                if(item)
                {
                    Console.WriteLine("Pizza " + i + " fits on the table.");
                }
                else
                {
                    Console.WriteLine("Pizza " + i + " does not fit on the table.");
                }
                i++;
            }
        }
    }
}
