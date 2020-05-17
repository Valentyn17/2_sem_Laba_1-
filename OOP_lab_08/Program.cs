using System;

namespace C_sharp_lab
{

    public delegate void MyDelegate(object temp, EventArgs args);    //delegate
    

    class Queue
    {
        public event MyDelegate MyEvent;
        int[] array=new int[5];
        int head=0;    //index of head of queue
        int tail=0;  //index of tail of queue
        int length=0;    //length of queue
       
        public void add(int x)        //adding  elem to queue
        {
            if (tail < array.Length)
            {
                array[tail] = x;
                length++;
                tail++;
                Console.WriteLine("Elem was added");
            }
            else
            {
                if (MyEvent != null)
                {
                    EventArgs args = new EventArgs();
                    MyEvent(this, args);
                }
            }

            
        }
        public void remove()        //removing elem from queue
        {
            if (head == length)
                head = 0;
            else
                head++;
            length--;
            Console.WriteLine("Elem was deleted");
        }
        public void output()       //outputing queue
        {
            Console.WriteLine("Our queue:");
            for(int i=head; i<tail;i++)
            Console.Write("{0}  ",array[i]);
            Console.WriteLine();
        }
    }

   

    class Program
    {
        static void Overflow(object temp, EventArgs args)      //func for event
        {
            Console.WriteLine("Queue is overflow!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("IS-92\nValentyn Zahray");
            Queue que = new Queue();
            que.MyEvent += new MyDelegate(Overflow);    //adding func to event
            que.add(5);    //adding element
            que.output();    //outputing
            
            que.add(7);
            que.output();
            
            que.remove();    //removing element
            que.output();
            
            que.add(2);
            que.output();
            
            que.add(4);
            que.output();
            
            que.add(6);
            que.output();

            que.add(7);     //queue will overflow
            que.output();
        }
    }
}
