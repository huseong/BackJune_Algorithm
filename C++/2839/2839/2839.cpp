// 2839.cpp: 콘솔 응용 프로그램의 진입점을 정의합니다.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int main()
{
	int input;
	cin >> input;
	int count = 0;
	int checker = 0;
	while (checker < input) {
		checker += 5;
		count++;
	} // checker 10 count 2
	if (checker == input) {
		cout << count << endl;
	}
	else {
		while (true) {
			checker -= 5;
			count--;
			if (checker < 0) {
				cout << -1 << endl;
				break;
			}
			if ((input - checker) % 3 == 0) {
				cout << count + (input - checker) / 3 << endl;
				break;
			}
		}
	}
    return 0;
}


