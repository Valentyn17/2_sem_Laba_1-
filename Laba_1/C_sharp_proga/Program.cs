using System;

namespace C_sharp_proga
{
    class Program
    {
        static void inkrement(ref int b)
        {
            int x = 0;
            while ((b & (1 << x)) != 0)
            {
                b ^= (1 << x);
                x++;
            }
            b ^=(1 << x);
        }

        static string chy_bilshe(int number1, int number2)
        {

            int key = Convert.ToString(Math.Abs(Math.Max(number1, number2)), 2).Length-1;
            for (int i=key;i>=0;i--)
            {
                if ((number1 & (number1 << i)) > (number2 & (number2 << i)))
                {
                    return $"Число {number1} бiльше нiж {number2}";
                }
            }
            return $"Число {number1} не бiльше ніж {number2}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть  число, яке будемо збiльшувати:");
            int a=Convert.ToInt32(Console.ReadLine());
            inkrement(ref a);
            Console.WriteLine("Iнкремент цього числа {0}", a);
            Console.WriteLine("Введiть два числа, якi будемо перевiряти операцiєю вiдношення  '>'  :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(chy_bilshe(num1,num2));
            Console.ReadKey();

        }
    }
}
