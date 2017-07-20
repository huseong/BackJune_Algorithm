using System;
using System.Collections.Generic;

namespace _4134
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 찾아야할 테스트 케이스의 개수
            uint[] input = new uint[n];
            for(int k=0; k<n; k++)
            {
                input[k] = uint.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            uint max = input[input.Length - 1];
            List<uint> list = new List<uint>();
            list.Add(0);
            list.Add(0);
            max++;
            int testCount = 0;
            bool chalk = false;
            int i = 2;
            while(true)
            {
                if(i == input[testCount])
                {
                    chalk = true;
                }
                bool check = true;
                for(int j=2; j<=Math.Sqrt(i); j++)
                {
                    if(list[j]==0)
                    {
                        continue;
                    }
                    if(i%j==0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    list.Add(1);
                    if(chalk)
                    {
                        chalk = false;
                        Console.WriteLine(i);
                        testCount++;
                        if (testCount == n)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    list.Add(0);
                }
                i++;
            }
        }
    }
}
