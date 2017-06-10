using System;
using System.Collections.Generic;

namespace _2605
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] chosenNum = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for(int i=0; i<n; i++)
            {
                chosenNum[i] = int.Parse(input[i]);
            }
            List<int> line = new List<int>();
            line.Add(1);
            for(int i=1; i<n; i++)
            {
                line.Insert(chosenNum[i], i + 1);
            }
            for(int i=0; i<n; i++)
            {
                Console.Write(line[n-i-1] + " ");
            }
        }
    }
}
