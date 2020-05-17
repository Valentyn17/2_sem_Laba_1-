#include <iostream>
using namespace std;

void sorting(char* array)    //func that sort array in inverse order
{
	int x = 0;
	do
	{	
		int j = x + 1;
		while (array[j] != '\0')
		{
			if (array[x]<array[j])
			{
				char k = array[x];
				array[x] = array[j];
				array[j] = k;
			}
			j++;
		} 
		x++;
	} while (array[x]!='\0');
	cout << array << endl;
}

int main()
{
	cout << "IS-92\nValentyn Zahray"<<endl;
	char mas[] = {'a','b','c','d','e','\0'};  //our array
	
	void(*pointer)(char*);     //pointer to func
	pointer = sorting;    //initialization
	pointer(mas);          //output


}

