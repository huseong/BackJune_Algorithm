using System;
using System.Collections.Generic;

namespace _4134
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 찾아야할 테스트 케이스의 개수
            uint[] input = new uint[n];
            for(int i=0; i < n; i++) {
                input[i] = uint.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            List<uint> list = new List<uint>();
            int targetIndex = 0;
            list.Add(2);
            for (uint i = 3; ; i++) {
                int root = (int)Math.Sqrt(i) + 1;
                bool check = true;
                for (int j = 0; j < list.Count; j++) {
                    if (list[j] > root) {
                        break;
                    }
                    if (i % list[j] == 0) {
                        check = false;
                        break;
                    }
                }
                if (check) {
                    if (i > input[targetIndex]) {
                        Console.WriteLine(i);
                        targetIndex++;
                        if (targetIndex == input.Length) {
                            break;
                        }
                    }
                    list.Add(i);
                }
            }
        }
    }
}
