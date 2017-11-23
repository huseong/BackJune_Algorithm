using System;

namespace _1517
{
    class Program
    {
        static ulong _answer = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[n];
            for(int i=0; i<n; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            mergeSort(inputs);
            Console.WriteLine(_answer);
        }

        static int[] copyArray(int[] arr, int startIndex, int size) {
            int[] array = new int[size];
            for(int i=0; i<size; i++) {
                array[i] = arr[startIndex + i];
            }
            return array;
        }

        static int[] merge(int[] arr1, int[] arr2) {
            int i = 0;
            int j = 0;
            int[] returnArray = new int[arr1.Length + arr2.Length];
            int count = 0;
            while(true) {
                if (arr2.Length == j) {
                    for (; i < arr1.Length; i++) {
                        returnArray[count++] = arr1[i];
                    }
                    break;
                }
                if (arr1.Length == i) {
                    for (; j<arr2.Length; j++) {
                        returnArray[count++] = arr2[j];
                    }
                    break;
                }
                if (arr1[i] <= arr2[j]) {
                    returnArray[count++] = arr1[i++];
                } else { 
                    _answer += (ulong)(arr1.Length - i);
                    returnArray[count++] = arr2[j++];
                }
            }
            return returnArray;
        }

        static int[] mergeSort(int[] arr) {
            if(arr.Length > 1) {
                int mid = arr.Length/2;
                return merge(mergeSort(copyArray(arr, 0, mid)), mergeSort(copyArray(arr, mid, arr.Length-mid)));
            }
            return arr;
        }
    }
}
