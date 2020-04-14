using System;

namespace Classes
{
    public class Lines
    {
        protected double x1, y1,x2,y2; //координати ліній

        public Lines(double x1, double y1,double x2,double y2)  //конструктор
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double length()    //метод отримання довжини
        {
            double rez = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2 - y1), 2));
            return rez;
        }
    }

    public class Segments : Lines
    {
        public Segments(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)  //створення конструктора похідного класу
        {
        }
        
        
        //методи отримання координат
        public double Get_begin_x_coord() => x1;   
        public double Get_begin_y_coord() => y1;
        public double Get_end_x_coord() => x2; 
        public double Get_end_y_coord() => y2;

        public double Angle_with_oX()  //кут з віссю
        {
            double cos_x=(x2-x1)/length();
            return Math.Acos(cos_x);
        }
    }

    public class Strings
    {
        protected char[] str;   // створення масиву чар
        public void Set(char[] stroka) => str = stroka;  // метод  запису строки
        virtual public char[] Get()  //метод отримання строки
        {
            return str;
        }

        virtual public int Get_length()  //метод отриманя  довжини строки
        {
            return str.Length;
        }

        virtual public char[] Add_symbol(char sym, int place)   //метод додавання символу до строки
        {
            Array.Resize(ref str, Get_length() + 1);
            for (int i = Get_length() - 1; i > place - 1; i--)
            {
                str[i] = str[i - 1];
            }
            str[place - 1] = sym;            
            return str;
        }
    };





    public class Big_letters : Strings  //похідний клас
    {
       
        public Big_letters(char[] stroka) : base()
        {
            string str1 = new string(stroka);
            str= str1.ToUpper().ToCharArray();
           
        }

        override public char[] Add_symbol(char sym, int place)   //метод додавання символу через символ '/'
        {
            Array.Resize(ref str, Get_length() + 2);
            for (int i = Get_length() - 1; i > place ; i--)
            {
                str[i] = str[i - 2];
            }
            str[place - 1] = '/';
            str[place ] = sym;
            return str;
        }


        public override char[] Get()
        {
            return str;
        }

        public override int Get_length()
        {
            return str.Length;
        }
    };


    public class Small_letters: Strings
    {

        public Small_letters(char[] stroka) : base()
        {
            string str1 = new string(stroka);
            str = str1.ToLower().ToCharArray();

        }

        override public char[] Add_symbol(char sym, int place)   //метод додавання символу через символ '/'
        {
            Array.Resize(ref str, Get_length() + 2);
            for (int i = Get_length() - 1; i > place; i--)
            {
                str[i] = str[i - 2];
            }
            str[place - 1] = '\\';
            str[place] = sym;
            return str;
        }


        public override char[] Get()
        {
            return str;
        }

        public override int Get_length()
        {
            return str.Length;
        }
    };


}
