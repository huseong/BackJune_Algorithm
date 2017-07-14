using System;

namespace _1463
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 0;
            for(int i=2; i<=n; i++) {
                int minValue = 1000001;
                if(i%3 == 0) {
                    if (arr[i / 3] < minValue) {
                        minValue = arr[i / 3];
                    }
                }
                if(i%2 == 0) {
                    if(arr[i/2] < minValue) {
                        minValue = arr[i / 2];
                    }
                }
                if(arr[i - 1] < minValue) {
                    minValue = arr[i - 1];
                }
                arr[i] = minValue + 1;
            }
            Console.WriteLine(arr[n]);
        }
    }
}
