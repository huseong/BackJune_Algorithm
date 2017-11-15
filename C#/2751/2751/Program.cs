using System;

namespace _2751 {
    class Program {
        static void Main(string[] args) {
            int inputLength = int.Parse(Console.ReadLine());
            int[] input = new int[inputLength];
            for (int i = 0; i < inputLength; i++) {
                input[i] = int.Parse(Console.ReadLine());
            }
            int maxValue = input[0];
            for (int i = 1; i < inputLength; i++) {
                if (maxValue < input[i]) {
                    maxValue = input[i];
                }
            }
            int[] count = new int[maxValue + 1];
            for (int i = 0; i < inputLength; i++) {
                count[input[i]]++;
            }
            for (int i = 1; i < count.Length; i++) {
                count[i] += count[i - 1];
            }
            int[] array = new int[count[maxValue]];
            for (int i = 0; i < inputLength; i++) {
                array[(count[input[i]]--) - 1] = input[i];
            }
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        static void quickSort(int[] arr, int left, int right) {
            int pivot = arr[(left + right) / 2];
            int i = left, j = right;
            while (i <= j) {
                while (arr[i] < pivot) {
                    ++i;
                }
                while (arr[j] > pivot) {
                    --j;
                }
                if (i <= j) {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    ++i;
                    --j;
                }
            }
            if (left < j) {
                quickSort(arr, left, j);
            }
            if (i < right) {
                quickSort(arr, i, right);
            }
        }
    }
}
