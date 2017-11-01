using System;

namespace _2748 {
    class Program {
        static void Main(string[] args) {
            long n = long.Parse(Console.ReadLine());
            long[] arr = new long[91];
            arr[0] = 0;
            arr[1] = 1;
            if (n == 1) {
                Console.WriteLine(1);
            } else {
                for (int i = 2; i <= n; i++) {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
                Console.Write(arr[n]);
            }
        }
    }
}
