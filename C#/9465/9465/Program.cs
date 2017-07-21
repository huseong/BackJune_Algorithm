using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9465 {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] answer = new int[n];
            for (int i = 0; i < n; i++) {
                int len = int.Parse(Console.ReadLine());
                int[,] arr = new int[2, len];
                string[] input = Console.ReadLine().Split(' ');
                int[] weight = new int[len]; // 가중치
                int[] selection = new int[len]; // 위 아래 선택. 0 일 경우 상단, 1일 경우 하단이다. -1 일 경우 하무것도 선택하지 않음이다.
                for (int j = 0; j < len; j++) {
                    arr[0, j] = int.Parse(input[j]);
                }
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < len; j++) {
                    arr[1, j] = int.Parse(input[j]);
                    weight[j] = Math.Abs(arr[0, j] - arr[1, j]);
                }
                // 배열 초기화
                bool temp = arr[0, 0] > arr[1, 0];
                int count = temp ? arr[0, 0] : arr[1, 0]; // 세기.
                selection[0] = temp ? 0 : 1;
                for(int j=1; j<len; j++) {
                    if(arr[0, j] > arr[1, j]) { // 상단이 더 크다면.
                        if(selection[j-1] == 0) { // 만약에 기존도 상단이었다면
                            if(arr[0, j-1] <= weight[j]) { // 만약 내 가중치가 충돌난 저놈보다 크다면
                                if(j==1 || selection[j-2] == 0) {
                                    selection[j - 1] = 1;
                                    selection[j] = 0;
                                    count -= arr[0, j-1];
                                    count += arr[1, j - 1];
                                    count += arr[0, j];
                                    continue;
                                }
                                selection[j - 1] = -1;
                                selection[j] = 0;
                                count += arr[0, j];
                                count -= arr[0, j - 1];
                                continue;
                            }
                            // 그렇지 않다면 가중치 비교를 해야함. 비교할 가중치는
                            int weightCheck = 0;
                            int checker = 0;
                            for(int k=j-1; k>=0; k--) {
                                if(selection[k] == -1) {
                                    break;
                                }
                                if(selection[k] == checker) {
                                    checker = checker == 0 ? 1 : 0;
                                    weightCheck += weight[k];
                                } else {
                                    break;
                                }
                            }
                            // 가중치 검사를 끝내고 만약 얘땜시 바껴야할 가중치가 얘로 얻는 가중치보다 더 크다면
                            if(weightCheck >= weight[j]) {
                                selection[j] = 1; // 하단을 선택한다.
                                count += arr[1, j];
                                weight[j] = arr[1, j] - arr[0, j];
                                continue;
                            } else { // 얘로 얻는 가중치가 얘땜시 바껴야할 가중치보다 더 크다면
                                int miniChecker = 0;
                                for (int k = j - 1; k >= 0; k--) {
                                    if (selection[k] == miniChecker) { // 충돌이 일어난 경우
                                        count -= arr[miniChecker, k]; // 기존의 값을 빼주고
                                        miniChecker = miniChecker == 0 ? 1 : 0; // 미니 체커의 값을 바꾸고
                                        selection[k] = miniChecker;
                                        count += arr[miniChecker, k];
                                        weight[k] = -Math.Abs(arr[0, k] - arr[1, k]);
                                    } else {
                                        break;
                                    }
                                }
                                selection[j] = 0;
                                count += arr[0, j];
                                continue;
                            }
                        }
                        else { // 만약 아니라면
                            selection[j] = 0;
                            count += arr[0, j];
                        }
                    } else if(arr[0, j] < arr[1, j]) { // 하단이 더 크다면
                        if (selection[j - 1] == 1) { // 만약에 기존도 하단이었다면
                            if (arr[1, j - 1] <= weight[j]) { // 만약 내 가중치가 충돌난 저놈보다 크다면
                                if (j == 1 || selection[j - 2] == 1) {
                                    selection[j - 1] = 0;
                                    selection[j] = 1;
                                    count -= arr[1, j - 1];
                                    count += arr[0, j - 1];
                                    count += arr[1, j];
                                    continue;
                                }
                                selection[j - 1] = -1;
                                selection[j] = 1;
                                count += arr[1, j];
                                count -= arr[1, j - 1];
                                continue;
                            }
                            // 그렇지 않다면 가중치 비교를 해야함. 비교할 가중치는
                            int weightCheck = 0;
                            int checker = 1;
                            for (int k = j - 1; k >= 0; k--) {
                                if (selection[k] == -1) {
                                    break;
                                }
                                if (selection[k] == checker) {
                                    checker = checker == 0 ? 1 : 0;
                                    weightCheck += weight[k];
                                } else {
                                    break;
                                }
                            }
                            // 가중치 검사를 끝내고 만약 얘땜시 바껴야할 가중치가 얘로 얻는 가중치보다 더 크다면
                            if (weightCheck >= weight[j]) {
                                selection[j] = 0; // 상단을 선택한다.
                                count += arr[0, j];
                                weight[j] = arr[0, j] - arr[1, j];
                                continue;
                            } else { // 얘로 얻는 가중치가 얘땜시 바껴야할 가중치보다 더 크다면
                                int miniChecker = 1;
                                for (int k = j - 1; k >= 0; k--) {
                                    if (selection[k] == miniChecker) { // 충돌이 일어난 경우
                                        count -= arr[miniChecker, k]; // 기존의 값을 빼주고
                                        miniChecker = miniChecker == 0 ? 1 : 0; // 미니 체커의 값을 바꾸고
                                        selection[k] = miniChecker;
                                        count += arr[miniChecker, k];
                                        weight[k] = -Math.Abs(arr[0, k] - arr[1, k]);
                                    } else {
                                        break;
                                    }
                                }
                                selection[j] = 1;
                                count += arr[1, j];
                            }
                        } else { // 만약 아니라면
                            selection[j] = 1;
                            count += arr[1, j];
                        }
                    }
                    else { // 두개의 값이 같은 경우
                        if(selection[j-1] == 0) {
                            selection[j] = 1;
                            count += arr[1, j];
                        }
                        else{
                            selection[j] = 0;
                            count += arr[0, j];
                        }
                    }
                }
                answer[i] = count;
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
