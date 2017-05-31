using System;

namespace _10800
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] color = new int[n];
            int[] size = new int[n];
            for(int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' });
                color[i] = int.Parse(input[0]);
                size[i] = int.Parse(input[1]);
            }
            for(int i=0; i<n; i++)
            {
                int eatableSum = 0;
                for(int j=0; j<n; j++)
                {
                    if (i == j)
                        continue;
                    if(color[i]!=color[j])
                    {
                        if(size[i] > size[j])
                        {
                            eatableSum += size[j];
                        }
                    }
                }
                Console.WriteLine(eatableSum);
            }
        }
    }
}
