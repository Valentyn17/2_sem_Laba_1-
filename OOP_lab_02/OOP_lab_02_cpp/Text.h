#ifndef TEXT
#define TEXT

#include "String.h"
#include <vector>

using namespace std;

class Text {
private:
	int size = 0;
	vector<String> text;
public:
	
	int get_length();
    void output_text();
	void add_line(char* );
	double middle_length();
	double vitsotok_holosnyh();
	//void find_and_delete(string);
	void delete_line(int );
    void clearing();
	

};

#endif