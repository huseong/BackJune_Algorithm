using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9086
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder a = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string input = Console.ReadLine();
                a.Append(input[0]);
                a.Append(input[input.Length - 1]);
                a.AppendLine();
            }
            Console.Write(a);
        }
    }
}
