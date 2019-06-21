// ConsoleApplication.cpp: определяет точку входа для консольного приложения.
//

#include <stdio.h>
#include <conio.h>
#include <tchar.h>
#include <string.h>
#include <math.h>
#include <iostream>
#include <iomanip>

using namespace std;

int main(void)
{
	setlocale(LC_ALL, "RUS");
	static char ch = '\0';
	static char* psz = new char[256];
	cout << ("Vvedite stroku: "); 
	cin >> psz;
	cout << ("Vvedite simvol: "); 
	cin >> ch;
	int i = 0, max = 0, max_i = max;
	do {
		int z = i, len = 0;
		while (psz[z] == ch) z++;
		if (z > i && (len = abs(z - i)) > max)
		{
			max_i = i; max = len;
		}
		i = (z <= i) ? i + 1 : z;
	} while (i < strlen(psz));
	cout << "length = " << max << endl;
	system("pause");
	return 0;
}
