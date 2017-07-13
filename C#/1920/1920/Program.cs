using System;

namespace _1920
{
    class Program
    {
        static int heapSize;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //자연수 n개의 개수
            string[] input = Console.ReadLine().Split(' '); //n개의 자연수들을 입력받음
            heapSize = n;
            //int[] arr = new int[heapSize + 1]; // 힙이 되어줄 배열
            //for (int i = 1; i < heapSize + 1; i++) {
            //    pushToHeap(arr, i, int.Parse(input[i-1]));
            //}
            //int[] arr2 = new int[heapSize + 1]; // 정렬된 배열을 담을 배열.
            //for (int i = 1; i < n + 1; i++) {
            //    arr2[i] = popFromHeap(arr, ref heapSize);
            //}
            int[] array2 = new int[input.Length];
            for(int i=0; i<array2.Length; i++) {
                array2[i] = int.Parse(input[i]);
            }
            int m = int.Parse(Console.ReadLine()); //자연수 m개의 개수
            string[] input2 = Console.ReadLine().Split(' '); //m개의 자연수를 입력받음
            for(int i=0; i<input2.Length; i++) {
                search(array2, int.Parse(input2[i]));
                Console.WriteLine(input2[i]);
            }
        }

        static void pushToHeap(int[] arr, int key, int value) {
            arr[key] = value;
            while(key > 1) {
                if(arr[key] < arr[key/2]) {
                    swap(ref arr[key], ref arr[key / 2]);
                    key /= 2;
                } else {
                    break;
                }
            }
        }

        static int popFromHeap(int[] arr, ref int heapSize) {
            int key = 1;
            int returnValue = arr[1];
            arr[1] = arr[heapSize];
            heapSize--;
            while(key*2 <= heapSize) {
                if(arr[key] > arr[key * 2]) {
                    if(arr[key] > arr[key*2 + 1]) {
                        if(arr[key*2] > arr[key*2+1]) {
                            swap(ref arr[key], ref arr[key * 2 + 1]);
                            key = key * 2 + 1;
                        } else {
                            swap(ref arr[key], ref arr[key * 2]);
                            key = key * 2;
                        }
                    } else {
                        swap(ref arr[key], ref arr[key * 2]);
                        key = key * 2;
                    }
                }
                else if(arr[key] > arr[key*2+1]) {
                    swap(ref arr[key], ref arr[key * 2 + 1]);
                    key = key * 2 + 1;
                } else {
                    break;
                }
            }
            return returnValue;
        }

        static void swap(ref int a, ref int b) {
            int tamp = a;
            a = b;
            b = tamp;
        }

        static void search(int[] arr, int value) {
            int left = 1;
            int right = (arr.Length - 1);
            int mid;
            while (true) {
                if (left > right) {
                    Console.WriteLine(0);
                    break;
                }
                mid = (left + right) / 2;
                if (arr[mid] > value) {
                    right = mid - 1;
                } else if (arr[mid] < value) {
                    left = mid + 1;
                }
                if (arr[mid] == value) {
                    Console.WriteLine(1);
                    break;
                }
            }
        }
    }
}
