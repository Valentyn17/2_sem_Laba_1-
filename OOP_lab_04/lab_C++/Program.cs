using System;
namespace OOP_04
{
    class Vector
    {
        private double x, y;   //coords of vectors
        public Vector(double firstcoord, double secondcoord)    //constructor with parametres
        {
            x = firstcoord;
            y = secondcoord;
        }
        public Vector() { }   //simple constructor
        public Vector(Vector a)   //copy constructor
        {
            x = a.x;
            y = a.y;
        }

        public double initx
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public double inity
        {
            get { return y; }
            set
            {
                y = value;
            }
        }

        public double length()  //  method for finding length of vector
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static Vector operator *(Vector vec, double num)   //overloaded operator *
        {
            Vector result = new Vector();
            result.x = vec.x * num;
            result.y = vec.y * num;
            return result;
        }
        public static Vector operator -(Vector vec1, Vector vec2)   //overloaded operator -
        {
            Vector result = new Vector();
            result.x = vec1.x - vec2.x;
            result.y = vec1.y - vec2.y;
            return result;
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Group IS-92\nZahray Valentyn");
            double x, y;
            Console.WriteLine("Input coord x for V1");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input coord y for V1");
            y = Convert.ToDouble(Console.ReadLine());
            Vector V1 = new Vector(x, y);
            Vector V2 = new Vector();
            Vector V3 = new Vector(V1);
            Console.WriteLine("Input coord x for V2");
            V2.initx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input coord y for V2");
            V2.inity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input coord x for V3");
            V3.initx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input coord y for V3");
            V3.inity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nVectors:\nCoords of V1 : ({0:0.0}  {1:0.0})", V1.initx, V1.inity);
            Console.WriteLine("Length of V1 : {0:0.0}", V1.length());
            Console.WriteLine("Coords of V2 : ({0:0.0}  {1:0.0})", V2.initx, V2.inity);
            Console.WriteLine("Length of V2 : {0:0.0}", V2.length());
            Console.WriteLine("Coords of V3 : ({0:0.0}  {1:0.0})", V3.initx, V3.inity);
            Console.WriteLine("Length of V3 : {0:0.0}", V3.length());
            V3 = V3 * 2;
            V1 = V3 - V2;
            Console.WriteLine("\nVectors after actions :");
            Console.WriteLine("Coords of V1 : ({0:0.0}  {1:0.0})", V1.initx, V1.inity);
            Console.WriteLine("Length of V1 : {0:0.0}", V1.length());
            Console.WriteLine("Coords of V2 : ({0:0.0}  {1:0.0})", V2.initx, V2.inity);
            Console.WriteLine("Length of V2 : {0:0.0}", V2.length());
            Console.WriteLine("Coords of V3 : ({0:0.0}  {1:0.0})", V3.initx, V3.inity);
            Console.WriteLine("Length of V3 : {0:0.0}", V3.length());
        }
    }
}
