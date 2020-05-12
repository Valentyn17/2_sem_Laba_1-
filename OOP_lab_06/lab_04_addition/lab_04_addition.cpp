#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

class Vector
{
private:
	double x, y;  //coords of vectors
public:
	Vector();  //simple constructor 
	Vector(const Vector&);  //copy constructor
	Vector(double, double);   //constructor with parametres
	double length();   // method for finding length of vector
	double Getx();     //getter of coord x
	void Setx(double);    //setter of coord x
	double Gety();       //getter of coord y
	void Sety(double);   //setter of coord y
	Vector operator *(double);   //overloaded operation *
	Vector operator -(Vector);    //overloaded operation -
};



int main()
{
	cout << "Group IS-92\nZahray Valentyn" << endl;
	double x1, y1, x2, y2, x3, y3;   //coords of vectors
	cout << "Input coord x for V1 : ";
	cin >> x1;
	cout << "Input coord y for V1 : ";
	cin >> y1;
	cout << "Input coord x for V2 : ";
	cin >> x2;
	cout << "Input coord y for V2 : ";
	cin >> y2;
	cout << "Input coord x for V3 : ";
	cin >> x3;
	cout << "Input coord y for V3 : ";
	cin >> y3;
	Vector V1;
	V1.Setx(x1);
	V1.Sety(y1);
	Vector V2 = V1;
	V2.Setx(x2);
	V2.Sety(y2);
	Vector V3(x3, y3);
	cout << "\nVectors : " << endl;
	cout << "Coords of V1: (" << fixed << setprecision(2) << V1.Getx() << "  " << fixed << setprecision(2) << V1.Gety() << ")" << endl;
	cout << "Length of V1: " << V1.length() << endl;
	cout << "Coords of V2: (" << fixed << setprecision(2) << V2.Getx() << "  " << fixed << setprecision(2) << V2.Gety() << ")" << endl;
	cout << "Length of V2: " << V2.length() << endl;
	cout << "Coords of V3: (" << fixed << setprecision(2) << V3.Getx() << "  " << fixed << setprecision(2) << V3.Gety() << ")" << endl;
	cout << "Length of V3: " << V3.length() << endl;
	
	
	try
	{
		V3 = V3 * 0;    //increasing vector 

	}
	catch(const char* mes)
	{
		cout <<"\n\nError!!!! "<< mes << endl;
	}
	V1 = V3 - V2;    //operation with overloaded -
	
	
	
	cout << endl << "Vectors after actions : " << endl;
	cout << "Coords of V1: (" << fixed << setprecision(2) << V1.Getx() << "  " << fixed << setprecision(2) << V1.Gety() << ")" << endl;
	cout << "Length of V1: " << V1.length() << endl;
	cout << "Coords of V2: (" << fixed << setprecision(2) << V2.Getx() << "  " << fixed << setprecision(2) << V2.Gety() << ")" << endl;
	cout << "Length of V2: " << V2.length() << endl;
	cout << "Coords of V3: (" << fixed << setprecision(2) << V3.Getx() << "  " << fixed << setprecision(2) << V3.Gety() << ")" << endl;
	cout << "Length of V3: " << V3.length() << endl;
	return 0;
}

Vector::Vector() {}

Vector::Vector(const Vector& vec)
{
	x = vec.x;
	y = vec.y;
}

Vector::Vector(double x, double y)
{
	this->x = x;
	this->y = y;
}

double Vector::length()
{
	return sqrt(pow(x, 2) + pow(y, 2));
}

double Vector::Getx() { return  x; }
double Vector::Gety() { return  y; }
void Vector::Setx(double x)
{
	this->x = x;
}
void Vector::Sety(double y)
{
	this->y = y;
}

Vector Vector::operator*(double num)
{
	if (num == 0)
		throw "Increasing on 0";
	return Vector(x * num, y * num);
}

Vector Vector::operator-(Vector vec)
{
	return Vector(x - vec.x, y - vec.y);
}
