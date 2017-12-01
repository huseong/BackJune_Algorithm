using System;

namespace _1110 {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            int cycle = 0;
            if (input < 10) {
                input *= 10;
            }
            int a = input;
            int b = 0;
            while (true) {
                b = a % 10 * 10 + (a % 10 + a / 10) % 10;
                cycle++;
                a = b;
                if (input == a) {
                    break;
                }
            }
            Console.Write(cycle);
        }
    }
}
