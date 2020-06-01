using System;

namespace Classes
{
    public class List
    {
        private Node Head;        //beginning of list
        private int count = 0, length = 0;     //length of list
        class Node     //dop class node 
        {
            public int data;   //our element
            public Node next;    //next node
        }

        public List ()    //constructor
        {
            Head = null;
        }

        public void Push(int a)    //adding element
        {
            Node p = Head;
            if (Head == null)
            {
                Head = new Node();
                Head.data = a;
                Head.next = null;
            }
            else
            {
                p = new Node();
                p.data = a;
                p.next = Head.next;
                Head.next = p;
            }
            length++;
        }

        public int this[int a]    //indexator for simple accessing to elements of list
        {
            get
            {
                Node p = Head;
                for (int i = 0; i < a; i++)
                {
                    p = p.next;
                }
                return p.data;
            }
        }
        public void output()      //outputing 
        {
            if (length == 0)    //there are no elems in list
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("Our list:");
                for (int i = 0; i < length; i++)
                    Console.Write("{0}  ",this[i]);
            }
            Console.WriteLine();
        }

        public int count_numbers_dividing_5()    //method that counts numbers dividing 5
        {

            Node p = Head;
            while (p != null)
            {
                if (p.data % 5 == 0)
                    count++;
                p = p.next;
            }
            return count;
        }


        private int find_max()    //method that find max in list
        {
            Node p;
            p = Head;
            int max = Head.data;
            p = Head.next;
            while (p != null)
            {
                if (p.data > max)
                {
                    max = p.data;
                    
                }
                p = p.next;
            }
            Console.WriteLine("Max element:\n{0}",max);
            return max;
        }


        public void remove_after()      //method that remove all elems after max
        {
            Node p = Head;
            int max = find_max();        //finding max
            while (Head.data != max)
            {
                Head = Head.next;
            }
            Node ptr = Head;
            while (Head.next != null)
            {
                length--;
                Head = Head.next;
            }
            Head = ptr;
            Head.next = null;
            Head = p;
        } 
    }
}

