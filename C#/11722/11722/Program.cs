using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11722 {
    class Program {
        static void Main(string[] args) {
            int inputLength = int.Parse(Console.ReadLine());
            string[] inputString = Console.ReadLine().Split(' ');
            int[] input = new int[inputLength];
            int[] Dp = new int[inputLength];
            for (int i = 0; i < inputLength; i++) {
                input[i] = int.Parse(inputString[i]);
            }
            Dp[inputLength-1] = 1;
            int max = 0;
            for (int i = inputLength-1; i > -1; i--) {
                int min = 0;
                for (int j = inputLength-1; j > i; j--) {
                    if (input[i] > input[j]) {
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
