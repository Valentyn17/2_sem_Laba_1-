#include <iostream>
#include <string>
#include <cstring>
#include "Text.h"

using namespace std;

void Text::output_text() 
{
	for ( int i=0; i<text.size();i++)
		text[i].output_string();
}


int Text::get_length()
{
	int key = 0;

	for (int i = 0; i < text.size(); i++)
		key += text[i].get_length();

	return key;
}


void Text::add_line(char* textToAdd) 
{
	text.push_back(textToAdd);
}

double Text::middle_length()
{
	return get_length() / (double)text.size();
}

double Text::vitsotok_holosnyh()
{
	int count = 0;
	for (int i = 0; i < text.size(); i++)
	{
		count += text[i].numb_of_holosni();
	}
	return ((double)count / get_length()) * 100;
}

void Text::delete_line(int num)
{
	text.erase(text.begin() + num-1 );
}

//void Text::find_and_delete(string str1)
//{
//	
//}

void Text::clearing()
{
	text.erase(text.begin(), text.end());
}


