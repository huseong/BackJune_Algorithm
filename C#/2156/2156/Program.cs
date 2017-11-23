using System;

namespace _2156 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int[] jans = new int[n];
            for (int i = 0; i < n; i++) {
                jans[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n && i < 3; i++) {
                count += jans[i];
            }
            if (n > 3) {
                int checkIndex = 3;
                int backUsing = 3;
                while (checkIndex < n) {
                    if (backUsing > 2) {
                        if (jans[checkIndex] > jans[checkIndex - 3]) {
                            count -= jans[checkIndex - 3];
                            count += jans[checkIndex];
                        } else {
                            backUsing = 0;
                        }
                    } else {
                        backUsing++;
                        count += jans[checkIndex];
                    }
                    checkIndex++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
