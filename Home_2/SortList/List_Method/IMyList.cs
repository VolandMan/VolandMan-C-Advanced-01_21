using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal interface IMyList<T>
    {

        void Add(T a);

        T this[int index] { get; }

        int Count { get; }

        void Clear();
        bool Contains(T item);
    }
}