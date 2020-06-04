using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
     public class Worker
    {
        public readonly string Name;
        public readonly int Age;
        public readonly string Position;
        public bool with_task; 
        
        public Worker(string name, int age, string position)
        {
            Name = name;
            with_task = false;
            Position = position;
            try
            {
                if (age < 100 && age > 16)
                    Age = age;
                else
                {
                    throw new Exception("Incorrent value of age(age must be between 16 and 100)");

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public override bool Equals(object obj)
        {


            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            if (ReferenceEquals(this, (Worker)obj))
                return true;
            else return false;
        }
    }
}
