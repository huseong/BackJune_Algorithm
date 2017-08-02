using System;

namespace _10799 {
    class Program {
        static void Main (string[] args) {
            string input = Console.ReadLine();
            int open = 0;
            int piece = 0;
            for(int i=0; i<input.Length; i++) {
                if(input[i] == '(') {
                    open++;
                }
                if(input[i] == ')') {
                    if(input[i-1] == ')') {
                        open--;
                        piece++;
                        continue;
                    }
                    open--;
                    piece += open;
                }
            }
            Console.WriteLine(piece);
        }
    }
}
