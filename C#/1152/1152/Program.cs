using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string scan = Console.ReadLine().Trim();
            int scanLength = scan.Length;
            int count = 0;
            for(int i=0; i<scanLength; i++)
            {
                if (scan[i] == ' ')
                {
                    if(scan[i-1]!=' ')
                    {
                        count++;
                    }
                }
            }
            if (scan != "")
                count++;
            Console.WriteLine(count);
        }
    }
}
