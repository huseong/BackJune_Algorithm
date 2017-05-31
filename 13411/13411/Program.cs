using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13411
{
    class Program
    {
        static public int jegob(int n)
        {
            return n * n;
        }
        class Data
        {
            public double time { get; set; }
            public int count = 1;
            private int num { get; set; }
            public Data()
            {
                this.num = count++;
            }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int data_x, data_y;
            double data_v;
            Data[] data = new Data[n];
            for(int i=0; i<n; i++)
            {
                string[] scan = Console.ReadLine().Split(new char[] { });
                data_x=int.Parse(scan[0]);
                data_y=int.Parse(scan[1]);
                data_v=double.Parse(scan[2]);
                data[i].time = Math.Sqrt(data_x * data_x + data_y + data_y) / data_v;
            }
            Array.Sort(data);
        }
    }
}
