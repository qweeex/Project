// Число инверсий.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream> 
#include <time.h> 

using namespace std;


int main()
{
	setlocale(LC_ALL, "RUS");
	srand(time(NULL));

	int size = 0;
	int f = 0;
	int *arr = new int[size];
	cout << "Введите размер массива: ";
	cin >> size;
	for (int i = 0; i < size; i++)
	{
		arr[i] = rand() % 100;
		cout << arr[i] << " ";
	}
	for (int i = 0; i < size - 1; i++)
	{
		if (arr[i] > arr[i + 1])
			f++;
	}
	cout << "\n" << f << "\n";

	system("pause");
	return 0;
}