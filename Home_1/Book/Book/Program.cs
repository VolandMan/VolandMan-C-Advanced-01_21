using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Book<int> mybook1 = new Book<int>("война и мир", 500);
            Book<double> mybook2 = new Book<double>("преступление и наказание", 350.5);
            
            mybook1.Show();
            mybook2.Show();

            Console.Read();
        }
    }
}
