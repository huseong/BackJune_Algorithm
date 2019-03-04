using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11719 {
    class Program {
        static void Main(string[] args) {
            string answer = "";
            string currentInput = Console.ReadLine();
            do {
                answer += (currentInput + "\n");
            } while ((currentInput = Console.ReadLine()) != null);
            Console.Write(answer);
        }
    }
}
