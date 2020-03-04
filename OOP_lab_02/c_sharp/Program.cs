using System;

namespace c_sharp
{
    class String
    {
        private	int lengh;
        private char str[] = new char[100];

        public static char* Create() 
        { }
        char* Get();
        int Get_lengh();
        void Outputing_string();
        private:
	char* str1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
