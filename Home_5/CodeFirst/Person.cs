using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        public ICollection<Phone> Phone_id { get; set; }

        public Person()
        {
            Phone_id = new List<Phone>();
        }
    }
}
