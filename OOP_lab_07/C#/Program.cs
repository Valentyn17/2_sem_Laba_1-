using System;
using Classes;
namespace C_sharp
{
    
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valentyn Zahray\nGroup IS-92\nLab 7");
            List list = new List();     //creating a list
            list.Push(5);    //adding element
            list.Push(6);
            list.Push(7);
            list.Push(10);
            list.output();      //outputing
            Console.WriteLine("Number of elements that divide 5: {0} ",list.count_numbers_dividing_5());     //counting numbers dividing 5
            list.remove_after();   //removing elements after max
            Console.WriteLine("Removing elements after max");    
            list.output();   //outputing

        }
    }

   
}
