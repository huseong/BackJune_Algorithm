using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13398 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(input[i]);
            }
            int[] Dp = new int[n];
            int startIndex = 0;
            int removeIndex = -1;
            Dp[0] = arr[0];
            for (int i = 1; i < n; i++) {
                if (arr[i] < 0) {
                    if (arr[i] > Dp[i - 1]) {
                        Dp[i] = arr[i];
                        startIndex = i;
                        continue;
                    }
                    int maxIndex = i - 1;
                    int maxCount = 0;
                    int max = int.MinValue;
                    for (int j = i - 1; j >= 0; j--) {
                        if (j == removeIndex) {
                            continue;
                        }
                        maxCount += arr[j];
                        if (maxCount > max) {
                            maxIndex = j;
                            max = maxCount;
                        }
                    }
                    startIndex = maxIndex;
                    if (removeIndex != -1) {
                        if (arr[removeIndex] > arr[i]) {
                            Dp[i] = max;
                        } else {
                            Dp[i] += arr[removeIndex];
                        }
                        removeIndex = i;
                    } else {
                        Dp[i] = max;
                    }
                } else {
                    if (Dp[i - 1] < 0) {
                        startIndex = i;
                        Dp[i] = arr[i];
                    } else {
                        Dp[i] = Dp[i - 1] + arr[i];
                    }
                }
            }
            int maxDp = int.MinValue;
            //Console.WriteLine();
            for (int i = 0; i < Dp.Length; i++) {
                //Console.WriteLine(Dp[i]);
                if (Dp[i] > maxDp) {
                    maxDp = Dp[i];
                }
            }
            Console.WriteLine(maxDp);
        }
    }
}
