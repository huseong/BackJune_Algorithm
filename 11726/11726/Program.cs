using System;

namespace _11726 {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            ulong[] array = new ulong[n];
            if (n < 3) {
                Console.WriteLine(n);
                return;
            }
            array[0] = 1;
            array[1] = 2;
            for(int i=2; i<n; i++) {
                array[i] = array[i - 1] + array[i - 2];
                if(array[i] > 10007) {
                    array[i] %= 10007;
                }
            }
            Console.WriteLine(array[n - 1]%10007);
        }
    }
}
