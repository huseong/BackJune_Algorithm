using System;

namespace _2579 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] Dp = new int[n];
            Dp[0] = arr[0];
            if (n == 1) {
                Console.WriteLine(arr[0]);
            } else if (n == 2) {
                Console.WriteLine(arr[0] + arr[1]);
            } else if (n == 3) {
                Console.WriteLine(arr[2] + getMax(arr[0], arr[1]));
            } else {
                Dp[1] = Dp[0] + arr[1];
                Dp[2] = arr[2] + getMax(arr[0], arr[1]);
                for (int i = 3; i < n; i++) {
                    Dp[i] = getMax(arr[i] + Dp[i - 2], Dp[i - 3] + arr[i] + arr[i - 1]);
                }
                Console.WriteLine(Dp[n - 1]);
            }
        }

        static int getMax(params int[] arr) {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
