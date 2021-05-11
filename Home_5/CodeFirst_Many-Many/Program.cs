using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CodeFirst_M_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ManyToManyEntity>());
           

            using (ManyToManyEntity db = new ManyToManyEntity())
            {
                Person person1 = new Person { Id = 1, Name = "Ivan", Last_Name = "Ivanov" };
                Person person2 = new Person { Id = 2, Name = "Andrey", Last_Name = "Andrey" };
                Person person3 = new Person { Id = 2, Name = "Petr", Last_Name = "Petrov" };

                db.PersonEntity.AddRange(new List<Person> { person1, person2, person3 });
                db.SaveChanges();

                Phone t1 = new Phone { Id = 1, Namber = "380976556564" };
                Phone t2 = new Phone { Id = 2, Namber = "380976458221" };
                Phone t3 = new Phone { Id = 3, Namber = "384545656445" };

                db.Phone.AddRange(new List<Phone> { t1, t2, t3 });
                db.SaveChanges();

                Projects project1 = new Projects() { Id = 1, Project_name = "Project1" };
                project1.Person.Add(person1);
                project1.Person.Add(person2);
                project1.Phone.Add(t1);
                project1.Phone.Add(t2);
                project1.Phone.Add(t3);                

                Projects project2 = new Projects() { Id = 2, Project_name = "Project2" };

                project2.Person.Add(person3);
                project2.Phone.Add(t2);
                project2.Phone.Add(t3);

                db.ProjectEntity.Add(project1);
                db.ProjectEntity.Add(project2);
                db.SaveChanges();



                foreach (var item in db.ProjectEntity.Include(e => e.Person).Include(s => s.Phone))
                {
                    Console.WriteLine("Project name: {0}", item.Project_name);

                    Console.WriteLine("Project employees: ");

                    foreach (var itemEmp in item.Person)
                    {
                        Console.WriteLine("{0} {1}", itemEmp.Name, itemEmp.Last_Name);
                    }
                    Console.WriteLine("Technology stack of the project: ");

                    foreach (var itemStacks in item.Phone)
                    {
                        Console.WriteLine("{0}", item.Namber);
                    }
                    Console.WriteLine("-----------------------------------------");
                }

                Console.ReadLine();
            }
            }
        }
}
