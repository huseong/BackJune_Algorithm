using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1517
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            string[] n = Console.ReadLine().Split(new char[] { ' ' });
            int[] b = new int[a];
            for(int i=0; i<a; i++)
            {
                b[i] = int.Parse(n[i]);
            }//여기까지 데이터 모두 받음
            int[] list = new int[a];
            list[0] = b[0];
            for(int i=1; i<b.Length; i++)
            {
                for(int j=i-1; j>=0; j--)
                {
                    if(b[i]<list[j])
                    {
                        list[j + 1] = list[j];
                        list[j] = 0;
                        count++;
                        if (j == 0)
                            list[0] = b[i];
                    }
                    else
                    {
                        list[j+1] = b[i];
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
