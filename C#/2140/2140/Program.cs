using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2140 {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            if (input < 3) {
                Console.WriteLine(0);
                return;
            }
            int answer = (int)Math.Pow((input - 2), 2);
            string[] read = new string[4];
            read[0] = Console.ReadLine();
            read[1]
        }
    }
}
