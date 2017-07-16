using System;
namespace _11052 {

    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            int[] memo = new int[input.Length];
            for(int i=0; i<n; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            memo[0] = inputs[0];
            for(int i=1; i<n; i++) {
                int max = inputs[i];
                for(int j=0; j < i/2+1; j++) {
                    if(max < memo[i-j-1] + memo[j]) {
                        max = memo[i - j - 1] + memo[j];
                    }
                }
                memo[i] = max;
            }
            Console.WriteLine(memo[n - 1]);
        }
    }
}
