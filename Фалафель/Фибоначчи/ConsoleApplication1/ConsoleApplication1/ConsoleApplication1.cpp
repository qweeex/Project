// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <cstdio>
#include <clocale>
#include <cmath>

using namespace std;

int main()
{	setlocale(LC_ALL, "rus");
	int n;
	cout << "Введите число: ";
	cin >> n;
	int num = 1, sub = 0, sch = 0, x = 0;
	while (1) {
		sch++;
		x = num;
		num += sub;
		sub = x;
		if (n == num) {
			cout << "Входит" << "\n";
			break;
		}
		if (sch > 1000) {
			cout << "Не входит" << "\n";
			break;
		}
	}
	system("pause");
}

