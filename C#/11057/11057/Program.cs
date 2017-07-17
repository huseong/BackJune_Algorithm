using System;

namespace _11057 {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, 10];
            for(int i=0; i<10; i++) {
                arr[0, i] = 1;
            }
            for(int i=1; i<n; i++) {
                for(int j=0; j<10; j++) {
                    for(int k=0; k<=j; k++) {
                        arr[i, j] += arr[i - 1, k];
                        if(arr[i, j] > 10007) {
                            arr[i, j] %= 10007;
                        }
                    }
                }
            }
            int count = 0;
            for(int i=0; i<10; i++) {
                count += arr[n - 1, i];
                if (count > 10007) {
                    count %= 10007;
                }
            }
            Console.WriteLine(count);
        }
    }
}
