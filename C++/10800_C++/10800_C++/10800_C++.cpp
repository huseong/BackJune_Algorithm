// 10800_C++.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int n = 0;
	std::cin >> n;
	std::cout << n << std::endl;
	int *color = new int[n];
	int *size = new int[n];
	for (int i = 0; i<n; i++)
	{
		char input[2];
		
		color[i] = int.Parse(input[0]);
		size[i] = int.Parse(input[1]);
	}
	for (int i = 0; i<n; i++)
	{
		int eatableSum = 0;
		for (int j = 0; j<n; j++)
		{
			if (i == j)
				continue;
			if (color[i] != color[j])
			{
				if (size[i] > size[j])
				{
					eatableSum += size[j];
				}
			}
		}
		Console.WriteLine(eatableSum);
	}
    return 0;
}

