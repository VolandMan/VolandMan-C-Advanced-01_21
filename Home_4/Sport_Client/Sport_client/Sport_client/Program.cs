using System;
using System.Collections.Generic;
using System.Linq;


namespace Sport_client
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clients> clients = new List<Clients>()
            {
                new Clients
                {
                    Id = 1,
                    Year = 2000,
                    Month = 11,
                    Time = 19
                },
                new Clients()
                {
                    Id = 2,
                    Year = 1999,
                    Month = 10,
                    Time = 21
                },
                new Clients()
                {
                    Id = 3,
                    Year = 2001,
                    Month = 8,
                    Time = 26
                },
                new Clients()
                {
                    Id = 4,
                    Year = 1998,
                    Month = 7,
                    Time = 28
                }
            };



            
            var q = clients.GroupBy(x => x.Time).OrderBy(x => x.Key).First().Select(x => new { x.Time, x.Year, x.Month }).Last();
            Console.WriteLine("{0}, {1}, {2}", q.Time, q.Year, q.Month);


        }

    }
}
    
