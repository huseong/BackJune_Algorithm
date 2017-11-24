using System;

namespace _2193 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            long[] Dp = new long[n];
            Dp[0] = 1;
            if (n == 1) {
                Console.WriteLine(1);
            } else if (n == 2) {
                Console.WriteLine(1);
            } else {
                Dp[1] = 1;
                for (int i = 2; i < n; i++) {
                    Dp[i] = Dp[i - 1] + Dp[i - 2];
                }
                Console.WriteLine(Dp[n - 1]);
            }

        }
    }
}
