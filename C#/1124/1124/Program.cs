using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1124
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' });
            List<int> list = new List<int>();
            list.Add(2);
            int counter = 0;
            for(int i=3; i<=int.Parse(a[1]); i++)
            {
                bool real = true;
                double sqrt = Math.Sqrt(i);
                for(int j=0; list[j]<=sqrt; j++)
                {
                    if(i%list[j]==0)
                    {
                        real = false;
                        break;
                    }
                }
                if(real)
                {
                    list.Add(i);
                }
            }
            for(int i=int.Parse(a[0]); i<=int.Parse(a[1]); i++)
            { 
                int su = i;
                int count = 0;
                for(int j=0; su!=1;j++)
                {
                    if(su%list[j]==0)
                    {
                        su /= list[j];
                        count++;
                        j--;
                    }
                }
                if (list.Contains(count))
                    counter++;
            }
            Console.Write(counter);
        }
    }
}
