using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class MyClassExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] resultArray = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                resultArray[i] = list[i];
            }

            return resultArray;
        }

    }
}
