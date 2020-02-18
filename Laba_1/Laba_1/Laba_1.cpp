#include <iostream>
#include <string>
#include <algorithm>
#include <cmath>
using namespace std;

bool chy_bilshe(int, int);
void inkrement(int&);

int main()
{
	setlocale(LC_ALL, "rus");
	int a;
	cout << "Введiть число яке будемо iнкрементувати : ";
	cin >> a;
	cout << "Результат : ";
    inkrement(a);
	cout << a << endl;
	
	int n1, n2;
	cout<<"Введiть два числа якi будемо порiвнювати знаком '>': "<<endl;
	cin >> n1 >> n2;
	if (chy_bilshe(n1, n2))
		cout << "Число " << n1 << " бiльше за число " << n2 << endl;
	else
		cout<< "Число " << n1 << "не бiльше за число " << n2 << endl;
	system("pause");
}


void inkrement(int &b)
{
	int x = 0;
	while ((b & (1 << x)) != 0)
	{
		b = b ^ (1 << x);
		x++;
	}
	b = b ^ (1 << x);

}


bool chy_bilshe(int number1, int number2)
{
	int k =to_string(abs(max(number1, number2))).length();
	bool key=false;
	for (int i = k; i >= 0; i--)
	{
		if ((number1 & (number1 << i)) > (number2 & (number2 << i)))
		{
			key = true;
		}
	}
	return key;
}


//string v_dva(int a)
//{
//	string chyslo="";
//	while (a > 0)
//	{
//		chyslo.insert(0, to_string(a % 2));
//		a /= 2;
//	}
//	return chyslo;
//}
