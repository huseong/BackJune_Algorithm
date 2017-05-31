using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1920
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //자연수 n개의 개수
            string[] scan = Console.ReadLine().Split(new char[] { ' ' }); //n개의 자연수들을 입력받음
            int[] se = new int[n];
            for(int i=0; i<n; i++)
            {
                se[i] = int.Parse(scan[i]); //n개의 자연수를 배열에 넣어놓음
            }
            n = int.Parse(Console.ReadLine()); //자연수 m개의 개수
            string[] scana = Console.ReadLine().Split(new char[] { ' ' }); //m개의 자연수를 입력받음
            int[] sa = new int[n]; //m개의 자연수를 넣을 배열
            for(int i=0; i<n; i++) 
            {
                sa[i] = int.Parse(scana[i]); //m개의 자연수를 배열에 넣음
            }
        }
    }
}
