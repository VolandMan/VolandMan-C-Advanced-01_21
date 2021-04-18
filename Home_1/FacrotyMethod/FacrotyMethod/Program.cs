using System;

namespace FacrotyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var customClass = MyClass<CastomClass>.FactoryMethod();
            
            customClass.GetInfo();

            Console.ReadLine();
        }
    }
}
