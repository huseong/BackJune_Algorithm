using System;

namespace _10844 {
    class Program {
        static void Main (string[] args) {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong[,] arr = new ulong[12, n];
            for(int i=1; i<11; i++) {
                arr[i, 0] = 1;
            }
            for(ulong i=1; i<n; i++) {
                for(int j=1; j<11; j++) {
                    arr[j, i] += (arr[j-1, i-1] + arr[j+1, i-1]) % 1000000000;
                }
            }
            ulong a = 0;
            for(int i=0; i<10; i++) {
                a += arr[i, n-1];
            }
            Console.WriteLine(a%1000000000);
        }
    }
}
