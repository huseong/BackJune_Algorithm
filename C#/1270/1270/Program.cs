using System;
using System.Collections.Generic;

namespace _1270
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] nums = new long[n]; // 지배한 번호를 저장할 배열.
            for(int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int soldierCount = int.Parse(input[0]);
                int needSoldier = soldierCount / 2 + 1;
                int[] soldier = new int[long.MaxValue];
                int len = soldierCount + 1;
                for (int j=1; j<len; j++)
                {
                    long value = long.Parse(input[j]);
                    if (++soldier[value] >= needSoldier) {
                        nums[i] = value;
                    }
                }
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
