#include "pch.h"
#include <iostream>
#include <math.h>
#include <cmath>

using namespace std;

int main()
{
	double res;
	int count = 0;
	for (int i = 0; i < 1000; i++)
	{
		res = pow(2, i) - i;
		res = fmod(res, 7);
		if (res == 0)
		{
			count++;
		}

	}
	cout << count << "\n";
	system("pause");
}
