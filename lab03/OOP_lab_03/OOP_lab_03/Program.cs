using System;

namespace OOP_lab_03
{
    class Program
    {
        class chysla
        {
            private const int rows = 3;
            private const int columns = 3;

            private int[,] numbers = new int[rows,columns] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  //масив чисел від 1 до 9
                                
           public int count_row {    //властивість для отриманняя кількості рядків 
                get
                {
                    return rows;
                }
            }
            public int count_columns {  //властиввість для отримання кількості стовпців
                get {
                    return columns;
                }
            }
           public int this[int i, int j]  //індексатор
            {
                get
                {
                    if (i > rows || i < 0 || j > columns || j < 0)
                    {
                        Console.WriteLine("Error!");
                        return -100;
                        
                    }
                    return numbers[i-1,j-1];
                }
                set 
                {
                    if (i > rows || i < 0 || j > columns || j < 0)
                        Console.WriteLine("Error!");
                    else
                        numbers[i, j] = value;
                }
            }

           
        };

        static void Main(string[] args)
        {

            Console.WriteLine("Group IS-92\nZahray Valentyn");
            chysla from_1_to_9=new chysla();
            char y;
            do
            {
                int row = 0, column = 0;   //номер рядка і номер стовпця
                Console.WriteLine("Input number of row: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input number of column: ");
                column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Element: {0} ", from_1_to_9[row, column]);
                Console.WriteLine("If you want to know another element write 'Y' : ");
                y = Convert.ToChar(Console.ReadLine());
            } while (y == 'Y');

            Console.WriteLine("Count of rows: {0}",from_1_to_9.count_row);  //вивід кількості рядків
            Console.WriteLine("Count of columns:{0} ", from_1_to_9.count_columns);  //вивід кількості стовпців
        }
    }
}
