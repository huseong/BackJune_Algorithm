using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2440
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder a = new StringBuilder();
            for(int i=n; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    a.Append("*");
                }
                a.AppendLine();
            }
            Console.Write(a);
        }
    }
}
