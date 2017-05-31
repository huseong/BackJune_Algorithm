using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a=Console.ReadLine().Split(new char[] { ' ' });
            Console.Write(int.Parse(a[0]) * int.Parse(a[1]));
        }
    }
}
