#include <iostream>
#include "List.h"
using namespace std;


int main()
{
	cout << "IS-92\nValentyn Zahray\nLab 7" << endl;
	List list = List();   //creating a list
	list.Push(9);            //adding element in list(adding after first element) 
	list.Push(5);              
	list.Push(6);
	list.Push(2);
	list.Push(10);
	list.Push(7);

	cout << "Our list: ";
	list.output();            //outputing our list
	
	cout<<"Number of elements in list that divide 5:  "<<list.Counting_numbers_dividing_5()<<endl;    //output count of numbersthat divide 5 in a list
	
	list.Remove_after();       //removing elems in list after max elem
	cout << "Removing elements after max element" << endl;
	
	cout << "Our list: ";
	list.output();
}
