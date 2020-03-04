#include <iostream>
#include <vector>
#include <string>
#include "String.h"
#include "Text.h"

using namespace std;

int main() 
{
	setlocale(LC_ALL, "rus");
	Text text;

	string line ;
	int n,num;
	cout <<"Ведите количество рядков: ";
	cin >> n;

	for (int i = 0; i <= n; i++) {
		
		if(i!=0)
			cout << "Введите " << i << "-ий рядок: ";
		char* str;
		getline(cin, line);
		str = new char[line.length() + 1];
		strcpy_s(str, line.length() + 1, line.c_str());
		if (i != 0)
		text.add_line(str);
		line = "";
	}

	cout << "Текст: "<<endl;
	text.output_text();
	
	cout << "Середня довжина рядкiв : "<< text.middle_length()<<endl;
	cout << "Процент голосних букв: " << text.vitsotok_holosnyh() << endl;

	cout << "Введите номер строки яку видалимо : ";
	cin >> num;
	text.delete_line(num);
	cout << "Текст: "<<endl;
	text.output_text();
   
	text.clearing();
	
	cout << "Текст очистився:" << endl;
	text.output_text();

	return 0;
}