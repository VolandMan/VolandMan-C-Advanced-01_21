using System;
using System.Collections.Generic;
using System.Text;

namespace FacrotyMethod
{
    public class MyClass<T>
    {
        public static T FactoryMethod()
        {
            return Activator.CreateInstance<T>();
        }
    }

}
