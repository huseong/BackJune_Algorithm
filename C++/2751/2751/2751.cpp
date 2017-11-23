// 2751.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include <set>
#include <iostream>
using namespace std;
int main()
{
	set<int> arr;
	int length;
	cin >> length;
	for (int i = 0; i < length; i++) {
		int input;
		cin >> input;
		arr.insert(input);
	}
	for (auto i : arr) {
		cout << i << '\n';
	}
    return 0;
}

