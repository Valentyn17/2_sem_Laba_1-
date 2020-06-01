#include <iostream>
#include "List.h"

List::List() { List::Head = nullptr; }   //constructor
int List::operator[](int n)    //overloaded operator  []
{
	Node* p;
	p = List::Head;
	int c = 0;
	for (c = 0; c < n; c++)
		p = p->Node::next;
	return p->data;
}

void List::Push(int a)     //adding element in list(adding after first element) 
{

	Node* p;
	p=Head;
	if (Head == nullptr)   //if list is empty
	{
		Head = new Node();
		Head->data = a;
		Head->next = nullptr;
	}
	else
	{
		p = new Node();
		p->data = a;
		p->next = Head->next;
		Head->next = p;
	}
	length++;
	
}

void List::output()     //outputing list
{
	if (length == 0)
		std::cout << "List is empty!" << std::endl;
	else
	{
		for (int i = 0; i < length; i++)
		{
			std::cout << (*this)[i] << "  ";
		}
		std::cout << std::endl;
	}
}

int List::Counting_numbers_dividing_5()   //counting numbers that divide 5
{
	Node* p = Head;  //pointer to Head
	while (p!=nullptr)  //
	{
		if (p->data % 5 == 0)
			count++;
		p = p->next;
	}
	return count;
}

List::Node* List::find_max()     //finding max in list
{
	Node* p;
	Node* ptr_to_max=Head; //pointer to head
	int max=Head->data;
	p = Head->next;
	while (p != nullptr)
	{
		if (p->data > max)
		{
			max = p->data;
			ptr_to_max = p;
		}
		p = p->next;
	}
	std::cout << "Max_element:\n" << ptr_to_max->data << std::endl;
	return ptr_to_max;
}


void List::Remove_after()    //deleting all elements after max_ele
{ 
	Node* ptr = find_max();   //pointer to node with max elem
	Node* p = Head;
	while ( Head!= ptr)
	{
		Head = Head->next;
	}
	ptr = Head;
	while (Head->next != nullptr)
	{
		length--;
		Head = Head->next;
	}
	Head = ptr;
	delete Head->next;
	Head->next= nullptr;
	Head = p;
	
}
