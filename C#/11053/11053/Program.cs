using System;
using System.Collections.Generic;
namespace _11053 {
    class Program {
        static void Main(string[] args) {
            int inputLength = int.Parse(Console.ReadLine());
            string[] inputString = Console.ReadLine().Split(' ');
            int[] input = new int[inputString.Length];
            int[] Dp = new int[inputLength];
            int max = 0;
            for (int i = 0; i < inputLength; i++) {
                input[i] = int.Parse(inputString[i]);
            }
            Dp[0] = 1;
            for (int i = 1; i < inputLength; i++) {
                int min = 0;
                for (int j = 0; j < i; j++) {
                    if (input[j] < input[i]) {
                        if (min < Dp[j]) {
                            min = Dp[j];
                        }
                    }
                }
                Dp[i] = min + 1;
                if (Dp[i] > max) {
                    max = Dp[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
