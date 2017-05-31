using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1120
{
    class Program
    {
        int dif(string a, string b)
        {
            int count = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] != b[i])
                    count++;
            }
            return count; //이 함수는 차이나는 경우의 개수를 반환합니다.
        }


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' });
            string input_1 = input[0];
            string input_2 = input[1];
            int num = input_2.Length - input_1.Length;
            for(int i=0; i<num; i++)
            {
                if(input_1[0])
            }
        }
    }
}
