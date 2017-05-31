using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2742
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=a; i>0; i--)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb);
        }
    }
}
