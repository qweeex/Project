// Число наоборот.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	setlocale (LC_ALL, "RUS");
	int x;
	int y = 1;
	cout << "Введите число: ";
	cin >> x;
	int length;

	do
	{
		y = x % 10;
		x /= 10;
		if (y == 0)
			break;
		cout << y;
	} while (y > 0);

	cout << endl;
	system("pause");
	return 0;
}
