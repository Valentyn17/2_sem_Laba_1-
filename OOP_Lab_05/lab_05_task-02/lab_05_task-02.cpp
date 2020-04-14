#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>
using namespace std;

class Strings      //base class
{
protected:
	
	char* str;     //string
public:
	void Set(string stroka)
	{
		str = new char[stroka.length()];
		strcpy(str, stroka.c_str());
	}
	virtual char* Get(){return str;	}     //getter
	virtual int   Get_length() { return strlen(str); };  //return length

	virtual void Add_symbol(char);     //virual method of adding symbol


};

class Big_letters :public Strings   //deritative class
{
public:
	Big_letters(string stroka) : Strings()
	{
		str = new char[stroka.length()];
		strcpy(str, stroka.c_str());
		for (int i = 0; i < strlen(str); i++)
		{
			str[i] = toupper(str[i]);
		}
	}

	virtual char* Get() { return str; }
	virtual int Get_length() { return strlen(str); }
	virtual void Add_symbol(char);
};


class Small_letters :public Strings
{
public:
	Small_letters(string stroka) : Strings()
	{
		str = new char[stroka.length()];
		strcpy(str, stroka.c_str());
		for (int i = 0; i < strlen(str); i++)
		{
			str[i] = tolower(str[i]);
		}
	}

	virtual char* Get() { return str; }
	virtual int Get_length() { return strlen(str); }
	virtual void  Add_symbol(char);
};



int main()
{
	cout << "Group IS-92\nValentyn Zahray\n" << endl;
	string stroka = "Hello I am Valentyn";    //our string 
	Strings str = Strings();                  // creating object of base class
	Big_letters str1 = Big_letters(stroka);     //creating object of first deritative class
	Small_letters str2 = Small_letters(stroka);   //creating object of second deritative class

	str.Set(stroka);
	cout << "String before actions:" << endl;
	cout << str.Get() <<endl<<"Length of string:  "<<str.Get_length()<<endl<< endl;   //output

	cout << "Strings after ations: " << endl;
	str.Add_symbol('!');     //adding symbol '!' to object of base class
	cout <<str.Get()<<"\nLength of string:  "<<str.Get_length()<< endl<<endl;  //result

	str1.Add_symbol('!');    //adding symbol '!' to object of first deritative class
	cout << str1.Get() << "\nLength of string:  " << str1.Get_length() <<endl<< endl;   //result

	str2.Add_symbol('!');    //adding symbol '!' to object of second  deritative class
	cout << str2.Get() << "\nLength of string:  " << str2.Get_length() <<endl<< endl;
}



void Strings::Add_symbol(char sym)
{
	char* str1 = new char [strlen(str)+1];
	for (int  i = 0; i < strlen(str); i++)
	{
		str1[i] = str[i];
	}
	
	str1[strlen(str)] = sym;
	str1[strlen(str) + 1] = '\0';
	str = str1;
	
}


void Big_letters::Add_symbol(char sym)
{
	char* str1 = new char[strlen(str) + 2];
	for (int i = 0; i < strlen(str); i++)
	{
		str1[i] = str[i];
	}

	str1[strlen(str)] = '/';
	str1[strlen(str) + 1] = sym;
	str1[strlen(str) + 2] = '\0';
	str = str1;

}


void Small_letters::Add_symbol(char sym)
{
	char* str1 = new char[strlen(str) + 2];
	for (int i = 0; i < strlen(str); i++)
	{
		str1[i] = str[i];
	}

	str1[strlen(str)] = '\\';
	str1[strlen(str) + 1] = sym;
	str1[strlen(str) + 2] = '\0';
	str = str1;

}
