using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2309
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for(int i=0; i<9; i++)
            {
                int n = int.Parse(Console.ReadLine());
                list.Add(n);
                sum += n;
            }
            bool chicken = false;
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9&&i!=j; j++)
                {
                    if(sum-list[i]-list[j]==100)
                    {
                        list.Remove(list[i]);
                        list.Remove(list[j]);
                        chicken = true;
                        break;
                    }
                }
                if (chicken)
                    break;
            }
            for(int i=6; i>=0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if(list[j]>list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
