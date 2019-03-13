#include "pch.h"
#include <iostream>
#include <time.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	srand(time(NULL));

	int arr[50];
	int size;
	cout << "Введите размер массива: ";
	cin >> size;
	for (int i = 0; i < size; i++)
	{
		arr[i] = 100 - rand() % 200;
		cout << arr[i] << " ";

	}
	int m = 0, p = 0, max_m = 0, max_p = 0;
	for (int i = 0; i < size; i++)
	{
		if (arr[i] < 0 && arr[i + 1] < 0)
		{
			m++;
		}
		else if (max_m < m)
		{
			max_m = m;
			m = 0;
		}
		else
		{
			m = 0;
		}

	}
	for (int i = 0; i < size; i++)
	{
		if (arr[i] > 0 && arr[i + 1] > 0)
		{
			p++;
		}
		else if (max_p < p)
		{
			max_p = p;
			p = 0;
		}
		else
		{
			p = 0;
		}

	}
	cout << endl << "Максимальное кол-во отрицательных чисел подряд: " << max_m + 1 << endl;
	cout << endl << "Максимальное кол-во положительных чисел подряд: " << max_p + 1 << endl;
	cout << endl;
	system("pause");
	return 0;
}
