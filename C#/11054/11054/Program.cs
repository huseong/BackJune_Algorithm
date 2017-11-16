using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11054 {
    class Program {
        static void Main(string[] args) {
            int inputLength = int.Parse(Console.ReadLine());
            string[] inputString = Console.ReadLine().Split(' ');
            int[] input = new int[inputLength];
            for (int i = 0; i < inputLength; i++) {
                input[i] = int.Parse(inputString[i]);
            }
            int maxLength = 0;
            int[] DpLeft = new int[inputLength];
            DpLeft[0] = 1;
            for (int i = 0; i < inputLength; i++) {
                int min = 0;
                for (int j = 0; j < i; j++) {
                    if (input[i] > input[j]) {
                        if (min < DpLeft[j]) {
                            min = DpLeft[j];
                        }
                    }
                }
                DpLeft[i] = min + 1;
            }
            int[] DpRight = new int[inputLength];
            DpRight[inputLength-1] = 1;
            for (int i = inputLength - 1; i > -1; i--) {
                int min = 0;
                for (int j = inputLength-1; j > i; j--) {
                    if (input[i] > input[j]) {
                        if (min < DpRight[j]) {
                            min = DpRight[j];
                        }
                    }
                }
                DpRight[i] = min + 1;
            }
            int max = 0;
            for (int i = 0; i < inputLength; i++) {
                if (max < DpRight[i] + DpLeft[i]) {
                    max = DpRight[i] + DpLeft[i];
                }
            }
            Console.WriteLine(max-1);
        }
    }
}
