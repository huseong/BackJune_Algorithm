using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11404 {
    class Program {
        static void Main (string[] args) {
            int cityCount = int.Parse(Console.ReadLine());
            int busCount = int.Parse(Console.ReadLine());
            int[,] minValue = new int[cityCount, cityCount];
            for(int i=0; i<cityCount; i++) { // 모든 값들에 대하여
                for(int j=0; j<cityCount; j++) {
                    if(i == j) {
                        minValue[i, j] = 0; // 만약에 두개가 같은 경우 최단거리는 0으로
                    } else {
                        minValue[i, j] = 100001; // 그렇지 않은경우 최대값 이상으로 초기화한다.
                    }
                }
            }
            for(int i=0; i<busCount; i++) { // 버스의 수 이다.
                string[] input = Console.ReadLine().Split(' ');
                int start = int.Parse(input[0]) - 1;
                int end = int.Parse(input[1]) - 1;
                int cost = int.Parse(input[2]);
                if(cost > minValue[start, end]) { // 만약 비용이 기존의 비용보다 크다면 그냥 지나간다.
                    continue;
                }
                minValue[start, end] = cost; // cost를 저장해놓는다.
            }
            for (int k=0; k<cityCount; k++) {
                for(int i=0; i<cityCount; i++) {
                    for(int j=0; j<cityCount; j++) {
                        if(minValue[i, j] > minValue[i, k] + minValue[k, j]) {
                            minValue[i, j] = minValue[i, k] + minValue[k, j];
                        }
                    }
                }
            }
            for (int i=0; i<cityCount; i++) {
                for(int j=0; j<cityCount; j++) {
                    if(minValue[i, j] == 100001) {
                        minValue[i, j] = 0;
                    }
                    Console.Write(minValue[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
