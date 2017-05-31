using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] scan= Console.ReadLine().Split(new char[] { ' ' });
                if (Console.ReadLine()=="")
                    break;
                Console.WriteLine(int.Parse(scan[0]) + int.Parse(scan[1]));
            }
        }
    }
}
