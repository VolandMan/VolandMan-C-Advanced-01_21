using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator <T1, T2> 
    {
        
        public static double Add(T1 t,  T2 t2)
            {
                var tValue = t as dynamic; 
                var tValue2 = t as dynamic;
           
                return (double)tValue + tValue2;
            }

        public static double Subtraction (T1 t, T2 t2)
        {
            var tValue = t as dynamic;
            var tValue2 = t as dynamic;

            return (double)tValue - tValue2;
        }

        public static double Multiplication(T1 t, T2 t2)
        {
            var tValue = t as dynamic;
            var tValue2 = t as dynamic;

            return (double)tValue * tValue2;
        }


    }
}
