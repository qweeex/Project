// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <conio.h>

using namespace std;

int max = 0;

int recurs(int* x, int y, int count)
{
	int result;
	int res = 0;
	if (x[count + 1] > max) {
		max = x[count + 1];
		count++;
	}
	else
		count++;
	if (count == 9)
		cout << max;
	else
		result = recurs(x, y, count);
	return max;
}

int main()
{
	int counter = 0;
	int arr[10] = {1,3,13,2,5,16,7,27,3,25};
	recurs(arr, 10, counter);
	
}

