#include <conio.h>
#include <iostream>
#include <cmath>
#include <stdlib.h>
#include <time.h>

using namespace std;

int din_array(int* arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 50;
		cout << arr[i] << "\n";
	}
	return arr, n;
}

int main()
{
	setlocale(LC_ALL, "RUS");
	int x = 0;
	cout << "Введите размерность массива: ";
	cin >> x;
	int median = 0;
	int summ = 0;
	int average = 0;
	int c = 0;
	int *num = new int [x];
	din_array (num, x);
	for (int i = 0; i < x; i++)
	{
		summ += num[i];
	}
	average = summ/x;
	if (x % 2 == 0)
	{
		median = x/2-1;
		median = num[median];
	}
	else
	{
		median = x / 2;
		median = num[median];
	}
	cout << "Среднее арифметическое - " << average << "\t" << "Медиана - " << median << "\n";
	if (average < median)
		cout << "True\n";
	else
		cout << "False\n";
	system("pause");
    return 0;
}


