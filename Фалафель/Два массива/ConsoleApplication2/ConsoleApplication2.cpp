#include "pch.h"
#include <iostream>

using namespace std;

int din_array(int* arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		cin >> arr[i];
	}
	return arr, n;
}

void sort(int* arr, int n)
{
	int f;
	do
	{
		f = 0;
		for (int i = 0; i < n - 1; i++)
		{

			if (arr[i] > arr[i + 1])
			{
				swap(arr[i], arr[i + 1]);
				f++;
			}
		}

	} while (f > 0);

	cout << arr[0] << " ";

	for (int i = 1; i < n; i++)
	{
		cout << arr[i] << " ";
	}
	cout << "\n";
}


int main()
{
	setlocale(LC_ALL, "RUS");
	int x;
	cout << "Введите размер массива:\n";
	cin >> x;
	int *arr = new int[x];
	cout << "Введите элементы 1 массива:\n";
	din_array(arr, x);

	int *arr2 = new int[x];
	cout << "Введите элементы 2 массива:\n";
	din_array(arr2, x);

	sort(arr, x);
	sort(arr2, x);

	int *result = new int[x*2];
	copy(arr, arr + x, result);
	copy(arr2, arr2 + x, result + x);

	cout << "Отсортированный массив: ";
	sort(result, x * 2);

	system("pause");
	return 0;
}

