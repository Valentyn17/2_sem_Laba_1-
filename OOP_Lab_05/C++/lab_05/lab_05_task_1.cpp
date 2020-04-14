#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>
using namespace std;

class  Lines    //клас лінії
{
protected:
	double x1, x2, y1, y2;  //координати 
public:
	Lines(double, double, double, double);   //конструктор 
	double length();

};

class Segments : public Lines  //клас відрізки
{
public:
	Segments(double x1, double y1, double x2, double y2) :Lines(x1, y1, x2, y2) {};  //конструктор похідного класу
	
	//метод отримання координат
	double Get_begin_x_coord() { return x1; };
	double Get_begin_y_coord() { return y1; };
	double Get_end_x_coord() { return x2; };
	double Get_end_y_coord() { return y2; };
	double Angle_with_OX();    //кутз  віссю OX
};





int main()
{
	cout << "Group IS-92\nValentyn Zahray" << endl;
	Segments Segment1(2, 1, 4, 3);
	cout << "Coords of beginning segment : " << Segment1.Get_begin_x_coord() << " " << Segment1.Get_begin_y_coord() << endl;
	cout << "Coords of end segment : " << Segment1.Get_end_x_coord() << " " << Segment1.Get_end_y_coord() << endl;
	cout << "Length of  segment : " << fixed << setprecision(2) << Segment1.length() << endl;
	cout << "Angle this segment with OX : " << setprecision(0)<<(Segment1.Angle_with_OX() * 180) / 3.14 << " degrees" << endl;
	return 0;
}

Lines::Lines(double x1, double y1, double x2, double y2)
{
	this->x1 = x1;
	this->x2 = x2;
	this->y1 = y1;
	this->y2 = y2;
}

double Lines::length()
{
	double rez = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
	return rez;
}

double Segments::Angle_with_OX()
{
	double cos_x = (x2 - x1) / length();
	return acos(cos_x);
}

