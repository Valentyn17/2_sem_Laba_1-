using System;
using Classes;
namespace OOP_lab_05
{
    class Program
    {
        static int Main(string[] args)
        {
            //task 1
            Console.WriteLine("Group IS-92\nVlentyn Zahray");
            Segments Segment1 = new Segments(2, 1, 4, 3);
            Console.WriteLine("Coords of beginning : {0}  {1}", Segment1.Get_begin_x_coord(), Segment1.Get_begin_y_coord());
            Console.WriteLine("Coords of end: {0}  {1}",Segment1.Get_end_x_coord(),Segment1.Get_end_y_coord());
            Console.WriteLine("Length of segment : {0:0.00}", Segment1.length());
            Console.WriteLine("Angle  with axis OX : {0} degrees ",Math.Round((Segment1.Angle_with_oX()*180)/Math.PI));

           


           // task 2
            Strings str = new Strings();
            Console.WriteLine("\nTask №2\n");
            Console.WriteLine("String before acts :");
            char[] string1 = ("Hello, I am Valentyn").ToCharArray();
            
            Big_letters str1 = new Big_letters(string1);
            Small_letters str2 = new Small_letters(string1);
            Console.WriteLine(string1);
            Console.WriteLine("\nString after acts :");
            str.Set(("Hello, I am Valentyn").ToCharArray());
            
            
            str.Add_symbol('!',6);
            str1.Add_symbol('!',6);
            str2.Add_symbol('!', 6);
            
            
            Console.WriteLine(str.Get());
            Console.WriteLine(str1.Get());
            Console.WriteLine(str2.Get());
            return 0;
        }
    }
}
