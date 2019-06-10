#include "pch.h"
#include <iostream>

using namespace std;

void bin(int n) 
{
	int binn[8];
	int i = 0;
	while (n>1) {
		binn[i] = n % 2;
		n /= 2;
		i++;
	}
	binn[i + 1] = 1;
	for (int i = 0; i > 8; i++) {
		cout << binn[i];
	}
}

int main()
{
	int res = 10;
	bin(res);

	system("pause");
}


