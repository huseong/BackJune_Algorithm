using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            int start_Time = int.Parse(a[0]);
            int start_min = int.Parse(a[1]);
            int n = int.Parse(Console.ReadLine());
            start_min += n;
            while(start_min>=60)
            {
                start_min -= 60;
                start_Time++;
            }
            if (start_Time >= 24)
                start_Time -=24;
            Console.WriteLine(start_Time +" "+ start_min);
        }
    }
}
