#include "conio.h"
#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");

	int n, c;
	int x = 0;
	cout << "Введите число: \n";
	cin >> n; 
	cout << "Введите цифру: \n";
	cin >> c;
	do
	{
		if (n % 10 == c)
		{
			x++;
		}
		n /= 10;

	} while (n > 0);

	cout << "Количество: " << x << endl;

	system("pause");
	return 0;
}

