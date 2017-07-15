using System;

namespace _9095 {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[11];
            arr[0] = 1; // 1
            arr[1] = 2; // 1 + 1, 2
            arr[2] = 4; // 1 + 1 + 1, 1 + 2, 2 + 1, 3
            for(int i=3; i<11; i++) {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            int[] input = new int[n];
            for(int i=0; i<n; i++) {
                input[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<n; i++) {
                Console.WriteLine(arr[input[i]-1]);
            }
        }
    }
}
