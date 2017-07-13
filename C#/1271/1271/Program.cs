using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1271
{
    class Program
    {
        class VeryBig {
            public ulong[] array;
            public bool end = false;
            public VeryBig(int arrayLength) {
                array = new ulong[arrayLength];
            }
            public VeryBig(string input) {
                array = new ulong[input.Length / 19+1];
                input = reverse(input);
                Console.Write(input);
                for(int i=0; i<array.Length-1; i++) {
                    array[i] = ulong.Parse(input.Substring(19 * i, 19));
                }
                array[array.Length - 1] = ulong.Parse(input.Substring(19 * (array.Length - 1)));
            }

            private static string reverse(string a) {
                string b = "";
                for(int i=0; i<a.Length; i++) {
                    b = a[a.Length - i-1].ToString();
                }
                Console.Write(b);
                return b;
            }

            public static bool operator >(VeryBig a, VeryBig b) {
                if(a.array.Length == b.array.Length) {
                    int max = a.array.Length-1;
                    while(true) {
                        if(a.array[max] == b.array[max]) {
                            max--;
                            if(max == 0) {
                                return false;
                            }
                            continue;
                        }
                        return a.array[max] > b.array[max];
                    }
                }
                return a.array.Length > b.array.Length;
            }

            public static bool operator < (VeryBig a, VeryBig b) {
                return !(a > b);
            }

            public void arrayShrink() {
                ulong[] arr = new ulong[array.Length - 1];
                for(int i=0; i<arr.Length; i++) {
                    arr[i] = array[i];
                }
                array = arr;
            }


            public static VeryBig operator -(VeryBig a, VeryBig b) {
                if(a < b) {
                    VeryBig big = new VeryBig(1);
                    big.end = true;
                    return big;
                }
                VeryBig returnBig = new VeryBig(a.array.Length);
                for(int i=0; i<a.array.Length; i++) {
                    if(i>b.array.Length-1) {
                        Console.WriteLine("히히 : " + a.array[i]);
                        returnBig.array[i] = a.array[i];
                        continue;
                    }
                    if(a.array[i] < b.array[i]) {
                        if(a.array[i+1]==1) {
                            a.arrayShrink();
                        } else {
                            a.array[i + 1]--;
                        }
                        a.array[i] += 10000000000000000000;
                    }
                    returnBig.array[i] = a.array[i] - b.array[i];
                }
                return returnBig;
            }

            public void plusOne() {
                int count = 0;
                array[count]++;
                while (true) {
                    if(array[count] > 10000000000000000000) {
                        array[count] = 1;
                        try {
                            array[++count]++;
                            continue;
                        } catch (IndexOutOfRangeException e){
                            ulong[] arr = new ulong[array.Length + 1];
                            for(int i=0; i<array.Length; i++) {
                                arr[i] = array[i];
                            }
                            arr[arr.Length - 1] = 1;
                            array = arr;
                        }
                    }
                    break;
                }
            }

            public static VeryBig operator /(VeryBig a, VeryBig b) {
                VeryBig returnVaule = new VeryBig(1);
                while(true) {
                    a -= b;
                    if(a.end) {
                        return returnVaule;
                    }
                    returnVaule.plusOne();
                }
            }

            public override string ToString () {
                string returnStr = "";
                for(int i=0; i<array.Length; i++) {
                    returnStr = array[i].ToString() + returnStr;
                }
                return returnStr;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            VeryBig a = new VeryBig(input[0]);
            Console.WriteLine(a.ToString());
            VeryBig b = new VeryBig(input[1]);
            Console.WriteLine((a - b).ToString());
        }
    }
}