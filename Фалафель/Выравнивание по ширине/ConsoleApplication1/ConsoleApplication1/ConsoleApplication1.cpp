#include "pch.h"
#include <iostream>
#include <string.h>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	ifstream inFile;
	ofstream outFile;
	inFile.open("txt.txt");
	outFile.open("out.txt");
	int n = 2;
	int count = 0;
	inFile.seekg(0, ios_base::beg);
	if (inFile) {
		char* buffer = new char[256];
		while (!inFile.eof()){
			inFile.seekg(count);
			inFile.get(buffer, n);
			outFile << buffer << "\n";
			count += n-1;
		}
		inFile.close();
		outFile.close();
	}
	else {
		cout << "File not opened";
	}
	
}

