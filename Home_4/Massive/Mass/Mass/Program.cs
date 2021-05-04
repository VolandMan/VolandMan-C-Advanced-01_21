using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[30]; 
            
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-20, 20);
            }

            
            foreach (var item in numbers)
            {
                Console.Write("{0} \t" , item);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 25));
            
           
          
            var positiveNums = numbers.Where(i => i >= 0);
            var negativeNums = numbers.Where(i => i < 0);
            var first = positiveNums.First();
            var last = negativeNums.Last();


            Console.WriteLine("first = {0}, \t last = {1}", first, last);



       
            Console.ReadKey();

        }
    }
}
