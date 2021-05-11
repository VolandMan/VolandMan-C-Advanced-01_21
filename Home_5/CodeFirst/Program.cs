using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OneToManyDbEntity>());

            using (OneToManyDbEntity db = new OneToManyDbEntity())
            {
                Phone phone1 = new Phone { Id = 1, Phone_number = "380976009010" };
                Phone phone2 = new Phone { Id = 2, Phone_number = "380532228403" };
                Phone phone3 = new Phone { Id = 3, Phone_number = "380650588772" };
           

                List<Phone> phone_list = new List<Phone>() { phone1, phone2 , phone3};
                db.PhoneEntities.AddRange(phone_list);

                db.SaveChanges();

                Person person1 = new Person
                {
                    Id = 2,
                    Name = "Ivan",
                    Last_name = "Ivamov",
                    Phone_id = phone_list
                };
                Person person2 = new Person
                {
                    Id = 2,
                    Name = "Andry",
                    Last_name = "Andrey",
                    Phone_id = phone_list
                };
                Person person3 = new Person
                {
                    Id = 3,
                    Name = "Fedor",
                    Last_name = "Fedorov",
                    Phone_id = phone_list
                };

                db.PersonEntities.Add(person1);
                db.SaveChanges();

                var entites = db.PersonEntities.Join(db.PhoneEntities,
                    person => person.Id,
                    phone => phone.PersonId,
                    (person, phone) => new
                    {
                        person.Name,
                        person.Last_name,
                        phone.Phone_number
                    });

                foreach (var item in entites)
                {
                    Console.WriteLine("{0} {1} - {2} ", item.Name, item.Last_name, item.Phone_number);
                }
                Console.ReadKey();
            }
        }
    }
}
