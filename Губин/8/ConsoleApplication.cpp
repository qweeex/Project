
#include <iostream>
#include <string>
#include <string.h>
#include <conio.h>
#include <cstdio>
#include <stdio.h>
#include <cstdlib>

using namespace std;


char HowMore(char *s1, char *s2)
{
	int k1 = 0;
	int k2 = 0;
	int res = 0;

	for (int i = 0; i < strlen(s1); i++)
	{
		if (s1[i] == ' ')
		{
			k1++;
		}
	}
	for (int i = 0; i < strlen(s2); i++)
	{
		if (s2[i] == ' ')
		{
			k2++;
		}
	}

	res = k1 - k2;

	return res;
}

int main()
{
	setlocale(LC_ALL, "RUS");
	int res = 0;

	char stroka[256];
	cout << "Ââåäèòå ïåðâóþ ñòðîêó: ";
	gets(stroka);
	char stroka2[256];
	cout << "Ââåäèòå âòîðóþ ñòðîêó: ";
	gets(stroka2);

	res = HowMore(stroka, stroka2);

	cout << res << "\n";

	if (res >= 3) {
		cout << stroka;
	}
	else if (res <= -3) {
		cout << stroka2 << "\n";
	}
	else {
		cout << "Not found\n";
	}

	system("pause");
    return 0;
}

