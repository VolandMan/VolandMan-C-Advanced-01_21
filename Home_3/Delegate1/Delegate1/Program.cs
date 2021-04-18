using System;

namespace Delegate1
{
    class Program
    {
        int a, b, c;
        public delegate double Mydelegate (int a, int b, int c); 

        public static double Average (int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите аргумент 1 =");

            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите аргумент 2 =");

            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите аргумент 3 =");

            int c = Int32.Parse(Console.ReadLine());



            Mydelegate mydelegate1 = new Mydelegate(Average);
            Console.WriteLine($"Average {a},{b},{c}  = "+ mydelegate1.Invoke(a, b, c));

            Console.WriteLine(new string('-', 10));


            Mydelegate mydelegate2 = delegate (int a, int b, int c) {return (a + b + c) / 3; };
            double average = mydelegate2.Invoke(a, b, c);
            Console.WriteLine($"Anonymous method Average = {a},{b},{c} = " + average);
           
            
            Console.ReadLine();

        }
    }
}
