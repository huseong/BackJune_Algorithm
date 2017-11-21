using System;

namespace _2156 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] Dp = new int[n];
            if (n == 1) {
                Console.WriteLine(arr[0]);
            } else if (n == 2) {
                Console.WriteLine(arr[0] + arr[1]);
            } else {
                Dp[0] = arr[0];
                Dp[1] = arr[1] + Dp[0];
                Dp[2] = chicken(Dp[1], Dp[0] + arr[2], arr[1] + arr[2]);
                for (int i = 3; i < n; i++) {
                    Dp[i] = chicken(Dp[i - 1], Dp[i - 2] + arr[i], arr[i] + arr[i - 1] + Dp[i - 3]);
                }
                Console.WriteLine(Dp[n - 1]);
            }
        }
        static int chicken(params int[] arr) {
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
