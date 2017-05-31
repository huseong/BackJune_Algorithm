using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            string[] b = Console.ReadLine().Split(new char[] { ' ' });
            int[] su = new int[int.Parse(a[1])];
            for(int i=0; i<int.Parse(a[0]); i++)
            {
                if (int.Parse(a[1]) > int.Parse(b[i]))
                    Console.Write(int.Parse(b[i]) + " ");
            }
        }
    }
}
