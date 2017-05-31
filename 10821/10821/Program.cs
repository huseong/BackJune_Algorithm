using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10821
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ',' });
            int a_length = a.Length;
            int count = 0;
            for(int i=0; i<a_length; i++)
            {
                if (a[i].Contains(".") == false)
                    count++;

            }
            Console.WriteLine(count);
        }
    }
}
