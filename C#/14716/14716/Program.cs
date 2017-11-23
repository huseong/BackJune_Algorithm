using System;
using System.Collections.Generic;

namespace _14716 {
    class Program {
        static void Main(string[] args) {
            string[] inputInfo = Console.ReadLine().Split(' ');
            int heigth = int.Parse(inputInfo[0]);
            int width = int.Parse(inputInfo[1]);
            bool[,] array = new bool[width, heigth];
            for (int i = 0; i < heigth; i++) {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < width; j++) {
                    array[j, i] = input[j][0] == '0' ? false : true; 
                }
            }
            int count = 0;
            bool beforeCheck = true;
            for (int i = 0; i < width; i++) {
                bool check = true;
                for (int j = 0; j < heigth; j++) {
                    if (array[i, j]) {
                        check = false;
                        beforeCheck = false;
                        break;
                    }
                }
                if (check) {
                    if (beforeCheck) {
                       continue;
                    }
                    beforeCheck = true;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
