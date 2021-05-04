using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char z;
            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие (+, - , *,) ");
            z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите b ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (z)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, Calculator<double, double>.Add(a, b));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, Calculator<double, double>.Subtraction(a, b));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, Calculator<double, double>.Multiplication(a, b));
                    break;
    
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadLine();
                       
     
        }
    }
}
