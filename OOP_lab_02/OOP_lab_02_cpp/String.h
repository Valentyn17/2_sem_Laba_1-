#ifndef STRING
#define STRING



#include <iostream>

class String {
private:
	char* line;
public:
	String(char* Line);
	int get_length();
	void output_string();
	int numb_of_holosni();
};


#endif