using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2744
{
    class Program
    {
        static void Main(string[] args)
        {
            string std= Console.ReadLine();
            char[] ch = new char[std.Length];
            for(int i=0; i<std.Length; i++)
            {
                if (std[i] >= 97)
                {
                    Console.Write(std[i].ToString().ToUpper());
                }
                else
                    Console.Write(std[i].ToString().ToLower());
            }
        }
    }
}
