#include "conio.h"
#include "math.h"
#include "iostream"
#include <iomanip>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	int x,res;
	cout << "Введите значение х: ";
	cin >> x;
	res = sqrt(fabs(pow(sin(x), 2))) / (x*3.01 - exp(2 * x));
	cout << "x = " << setprecision(2) << res << "\n";
	system("pause");
    return 0;
}

