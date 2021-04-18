using System;

namespace Delegate2
{
    class Program
    {
        public delegate int MyDelegat(int num1, int num2);
        static void Main()
        {
           
            Console.WriteLine("Первое число = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число = ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выбор операции  +,-,*,/");
            string a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    MyDelegat myDelegat = (num1, num2) => { return num1 + num2; };
                    int sum = myDelegat(x, y);
                    Console.WriteLine("Сумма чисел:{0}", sum);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (num1, num2) => { return num1 - num2; };
                    int sub = myDelegat1(x, y);
                    Console.WriteLine("Результат вычитания:{0}", sub);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (num1, num2) => { return num1 * num2; };
                    int mul = myDelegat2(x, y);
                    Console.WriteLine("езультат умнодения:{0}", mul);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (num1, num2) => { return num1 / num2; };
                    int div = myDelegat3(x, y);
                    Console.WriteLine("Результат деления:{0}", div);
                    break;
                default:
                    Console.WriteLine("Выберите из предложанного");
                    break;
            }

            Console.ReadKey();

        }
    }
}
