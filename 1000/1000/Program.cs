using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b=a.Split(new char[] { ' ' });
            Console.WriteLine(int.Parse(b[0])+int.Parse(b[1]));
        }
    }
}
