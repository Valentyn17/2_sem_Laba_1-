#pragma once


class List
{
public:
	List();
	class Node   
	{
	public:
		
		Node* next;      //pointer to next elem
		int data;             //field that will stores valur
	};
	void Push(int);           //method adding to list after first elem
	int operator[](int);        //overloaded operator
	void output();            //outputing list
	int Counting_numbers_dividing_5();        //counting numbers that divide 5
	void Remove_after();       //deleting all elements after max_elem
private:
	Node* Head;        //pointer to the start of the list
	Node* find_max();   //finding max 
	int length=0;       //lengrh of list
	int count;
	
};

