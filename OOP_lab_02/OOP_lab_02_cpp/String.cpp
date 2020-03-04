#include <iostream>
#include <string>
#include "String.h"

using namespace std;

String::String(char* Line) {
	line = Line;
}

int String::get_length() {
	return strlen(line);
}

int String::numb_of_holosni()
{
int counter=0;
char holosni[] = "AOIUYEaoiuyeÀÎÈÓÅŞßª¯¿ºşÿîàåóè";
for (int i = 0; i < strlen(line); i++)
{
	for (int j = 0; j < strlen(holosni); j++)
	{
		if (line[i] == holosni[j])
			counter++;
	}
}
return counter;
}

void String::output_string() {
	for (int i = 0; i < strlen(line); i++)
		cout << line[i];
	cout << endl;
}

char* String::Get()
{
	return line;
}