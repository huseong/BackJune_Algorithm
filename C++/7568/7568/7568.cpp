#include "stdafx.h"
#include <iostream>
using namespace std;
struct Person
{
public:
	int weight;
	int height;
	int rank;
};
int main()
{
	int length;
	cin >> length;
	Person* arr = new Person[length];
	for (int i = 0; i < length; i++) {
		int height, weight, rank;
		cin >> height;
		cin >> weight;
		arr[i].height = height;
		arr[i].weight = weight;
		arr[i].rank = 1;
	}
	for (int i = 0; i < length; i++) {
		for (int j = 0; j < length; j++) {
			if (arr[i].weight > arr[j].weight && arr[i].height > arr[j].height) {
				arr[j].rank++;
			}
		}
	}
	for (int i = 0; i < length; i++) {
		cout << arr[i].rank << ' ';
	}
    return 0;
}

