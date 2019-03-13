// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "RUS");
	int x;
	cout << "Введите размер массива:\n";
	cin >> x;
	int *arr = new int [x];
	cout << "Введите элементы массива:\n";

	for (int i = 0; i < x; i++)
	{
		cin >> arr[i];
	}

	int f;
	do
	{
		f = 0;
		for (int i = 0; i < x - 1; i++)
		{

			if (arr[i] > arr[i + 1])
			{
				swap(arr[i], arr[i + 1]);
				f++;
			}
		}

	} while (f > 0);

	cout << arr[0] << " ";

	for (int i = 1; i < x; i++)
	{
		if (arr [i]>arr[i-1])
		cout << arr[i] << " ";
	}
	cout << "\n";

	system("pause");
	return 0;
}
