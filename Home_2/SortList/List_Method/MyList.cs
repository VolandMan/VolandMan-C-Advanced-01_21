using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class MyList<T> : IMyList<T>
    {
        private T[] array = null;

        public MyList()
        {
            array = new T[0];
        }

        public T this[int index] => array[index];


        public int Count => array.Length;

        public void Add(T a)
        {
            if (array == null)
            {
                array = new T[0];
            }
            T[] resultArray = new T[array.Length + 1];
            this.array.CopyTo(resultArray, 0);
            resultArray[resultArray.Length - 1] = a;
            
            array = resultArray;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
           for(int i = 0; i < array.Length; i++)
            {
                if(array[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
