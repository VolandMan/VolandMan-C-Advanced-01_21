using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CAR
{
    class Program
    {
    

        static void Main(string[] args)
        {

            DateTime myDate = new DateTime(2005, 12, 31);

            List<Car> carList = new List<Car>
            {


                new Car
                {
                
                    ModelCar = "BMW",

                    NameCar = "BMW-L3",

                    ColorCar = "Blue",

                    MadeDate = new DateTime(2009, 6, 2)
                },

                new Car
                {
                  
                    ModelCar = "Lada",

                    NameCar = "Colina",

                    ColorCar = "White",

                    MadeDate = new DateTime(2000, 3, 5)
                },

                new Car
                {
                 
                    ModelCar = "volkswagen",

                    NameCar = "Passat",

                    ColorCar = "Black",

                    MadeDate = new DateTime(1999, 8, 6)
                },


            };

            List<Buyer> buyetList = new List<Buyer>
            {

                  new Buyer
                {
                    
                    BuyerName = "Ivan",

                    BuyerPhone = "380976057063",

                    BuyerCarModel = "BMW",
                                       
                },

                    new Buyer
                {
                   
                    BuyerName = "Alex",

                    BuyerPhone = "380986059062",

                    BuyerCarModel = "Lada",

                },

                      new Buyer
                {
                    
                    BuyerName = "Vlad",

                    BuyerPhone = "380987159047",

                    BuyerCarModel = "volkswagen",

                },

            };



            var query = from buyer in buyetList
                        join car in carList
                        on buyer.BuyerCarModel equals car.ModelCar
                        orderby car.ModelCar descending 
                        select new
                        {
                        
                            buyer = buyer.BuyerName,
                            Phone = buyer.BuyerPhone,

                            Name = car.NameCar,
                            Model = car.ModelCar,
                            Data = car.MadeDate
                                                        
                        };

            Console.WriteLine(new string('-', 20));

            foreach (var person in query)
            {
                Console.WriteLine("{0},Phone: {1} \t {2},{3},{4},", person.buyer, person.Phone, person.Model, person.Name, person.Data);
            }



            

           Console.Read();
        }

    }
}
