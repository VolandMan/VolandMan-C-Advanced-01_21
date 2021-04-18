using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{ 
    /// <summary>
    /// Books Shop
    /// </summary>
    /// <typeparam Price  for Book="T"></typeparam>
    class Book <T>
    {
        private string Name { get; set; }
        private T Price { get; set;}
        
        public Book (string name, T prise)
        {
            this.Name = name;
            this.Price = prise;
        }

        public void Show()
        {
            Console.WriteLine($"Book: {Name}  Price: {Price}");
        }

    }
}
