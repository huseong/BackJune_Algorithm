using System;

namespace _7568 {
    class Program {

        struct Person {
            public byte weight;
            public byte height;
            public byte rank;
        }
        static void Main(string[] args) {
            byte n = byte.Parse(Console.ReadLine());
            Person[] arr = new Person[n];
            for (byte i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ');
                arr[i].weight = byte.Parse(input[0]);
                arr[i].height = byte.Parse(input[1]);
                arr[i].rank = 1;
                for (byte j = 0; j < i; j++) {
                    if (arr[i].rank > arr[j].rank) {
                        arr[i].rank++;
                    } else {
                        if (arr[i].weight > arr[j].weight && arr[i].height > arr[j].height) {
                            arr[j].rank++;
                        } else if (arr[i].weight < arr[j].weight && arr[i].height < arr[j].height) {
                            arr[i].rank++;
                        }
                    }
                }
            }
            for (byte i = 0; i < n; i++) {
                Console.Write(arr[i].rank + " ");
            }
        }
    }
}
