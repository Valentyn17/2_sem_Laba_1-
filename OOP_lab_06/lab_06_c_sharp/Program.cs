using System;

namespace OOP_lab_06
{

    class Expression
    {
        private double rez, a, c, d;
        public Expression(double a, double c, double d)   //constructor
        {
            this.a = a;

            this.c = c;
            this.d = d;
        }

        public double solve()    //method thatsolve the expression
        {
            
            double rez1 = 2 * c - d / 23;      //чисельник виразу
            double rez2 = Math.Log(1 - a / 4);   //знаменник виразу
            rez = rez1 / rez2;
            if (1 - a / 4 <= 0)
            {
                throw new Exception("Logarythmic function value exception");    //logarythm exception
            }      
            if (rez2 == 0)
            { 
            throw new DivideByZeroException("Dividing by zero");     //divide by zero
            }
            return rez;
        }


    }
    


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Group IS-92\nZahray Valentyn");
            Expression[] expressions = new Expression[4];
           expressions[0] = new Expression(2, 4, 3);
           expressions[1] = new Expression(0, 0.5, 23);  //exception
           expressions[2] = new Expression(4, 3, 5);  //exception
           expressions[3] = new Expression(1, 1, 2);
            int i = 0;
            foreach (var element in expressions)
            { 
                i++;
                try
                {
                   Console.WriteLine("Expression № {0} {1} ",i,element.solve());        //outputing
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);   //outputing exception
                }
            }

        }

    }
}