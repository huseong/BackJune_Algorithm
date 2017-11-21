using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9465 {
    class Program {
        static void Main (string[] args) {
            int testCount = int.Parse(Console.ReadLine());
            int[] testResult = new int[testCount];
            for (int i = 0; i < testCount; i++) {
                int row = int.Parse(Console.ReadLine());
                int[,] arr = new int[2, row];
                string[] topLine = Console.ReadLine().Split(' ');
                string[] bottomLine = Console.ReadLine().Split(' ');
                for (int j = 0; j < row; j++) {
                    arr[0, j] = int.Parse(topLine[j]);
                    arr[1, j] = int.Parse(bottomLine[j]);
                }
                int[,] Dp = new int[2,row];
                Dp[0, 0] = arr[0, 0];
                Dp[1, 0] = arr[1, 0];
                if (row == 1) {
                } else {
                    Dp[0, 1] = arr[1, 0] + arr[0, 1];
                    Dp[1, 1] = arr[0, 0] + arr[1, 1];
                    for (int j = 2; j < row; j++) {
                        Dp[0, j] = getMax(Dp[1, j - 1] + arr[0, j], Dp[1, j - 2] + arr[0, j]);
                        Dp[1, j] = getMax(Dp[0, j - 1] + arr[1, j], arr[1, j] + Dp[0, j - 2]);
                    }
                }
                testResult[i] = getMax(Dp[0, row - 1], Dp[1, row - 1]);
            }
            foreach (var item in testResult) {
                Console.WriteLine(item);
            }
        }

        static int getMax(params int[] arr) {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) {
                max = max > arr[i] ? max : arr[i];
            }
            return max;
        }
    }
}
