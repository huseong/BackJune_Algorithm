// 1110.cpp: 콘솔 응용 프로그램의 진입점을 정의합니다.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int main()
{
	int input;
	cin >> input;
	int cycle = 0;
	if (input < 10) {
		input *= 10;
	}
	int a = input;
	int b = 0;
	while (true) {
		b = a % 10 * 10 + (a % 10 + a / 10) % 10;
		cycle++;
		a = b;
		if (input == a) {
			break;
		}
	}
	cout << cycle << endl;
    return 0;
}

