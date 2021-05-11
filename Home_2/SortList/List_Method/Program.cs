using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> myList = new MyList<int>();

            Console.WriteLine("Начальная длинна списка: {0}", myList.Count);
            myList.Add(2);
            Console.WriteLine("Наличие 2: {0}", myList.Contains(2));
            Console.WriteLine("Наличие 5: {0}", myList.Contains(5));
            Console.WriteLine("Длиннна списка полсле: {0}", myList.Count);
            myList.Clear();

            for(int i = 0; i < 20; i++)
            {
                myList.Add(i);
            };

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            };

                     
            int[] array = myList.GetArray();
            Console.WriteLine("Расширенный метод");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(array[i]);
            };

        }
    }
 
}
