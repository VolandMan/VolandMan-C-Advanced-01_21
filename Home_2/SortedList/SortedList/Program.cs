using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static IEnumerable<T> CreateReverseIterator<T>(IList<T> list)
        {
            int count = list.Count;
            for (int i = count - 1; i >= 0; --i)
            {
                yield return list[i];
            }
        }
        static void Main(string[] args)
        {
            SortedList<int, string> UserInfo = new SortedList<int, string>();

         
            UserInfo.Add(1, "DEN");
            UserInfo.Add(2, "HANNA");
            UserInfo.Add(3, "JAK");
            UserInfo.Add(4, "Mike");
            UserInfo.Add(5, "Alex");
            UserInfo.Add(6, "Jozef");



            ICollection<int> keys = UserInfo.Keys;
                     
            foreach (int s in keys)
                Console.WriteLine("Number: {0}, Name: {1}", s, UserInfo[s]);

            Console.WriteLine(new string('-', 20));

            string[] values = new string[UserInfo.Values.Count];
            UserInfo.Values.CopyTo(values, 0);

            foreach (string value in CreateReverseIterator(values))
            {
                Console.WriteLine("Value: {0}", value);
            }


            Console.ReadLine();

           
        }
    }
}
