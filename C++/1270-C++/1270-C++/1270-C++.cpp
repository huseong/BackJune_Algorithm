// 1270-C++.cpp : Defines the entry point for the console application.
//

#include <iostream>
#include <map>
using namespace std;

int main()
{
	int n; // 땅의 개수
	cin >> n;
	int* nums = new int[n];
	for (int i = 0; i < n; i++) {
		nums[i] = NULL;
		int soldierCount;
		cin >> soldierCount; // 군인들의 개수 넣어놓기
		int needSolider = soldierCount / 2 + 1;
		map<int, int> soldier;
		for (int j = 0; j < soldierCount; j++) {
			int soldierNum;
			cin >> soldierNum;
			if (++soldier[soldierNum] >= needSolider) {
				nums[i] = soldierNum;
			}
		}
	}
	for (int i = 0; i < n; i++) {
		if (nums[i] == NULL) {
			cout << "SYJKGW" << endl;
			continue;
		}
		cout << nums[i] << endl;
	}
	delete[] nums;
    return 0;
}

