using System;
using System.Collections.Generic;

namespace _1270
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] nums = new long[n];
            Console.WriteLine(n);
            for(int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int soldierCount = int.Parse(input[0]);
                Dictionary<string, long> count = new Dictionary<string, long>();
                long maxNum = long.MinValue;
                string maxCountry = "";
                for(int j=1; j<soldierCount; j++)
                {
                    if(!count.ContainsKey(input[j]))
                    {
                        count.Add(input[j], 1);
                    }
                    else
                    {
                        count[input[j]] += 1;
                    }
                    if(count[input[j]] > maxNum)
                    {
                        maxNum = count[input[j]];
                        maxCountry = input[j];
                    }
                }
                if(maxNum<=soldierCount * 0.5f)
                {
                    nums[i] = 0;
                    continue;
                }
                nums[i] = long.Parse(maxCountry);
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    Console.WriteLine("SYJKGW");
                    continue;
                }
                Console.WriteLine(nums[i]);
            }
        }
    }
}
