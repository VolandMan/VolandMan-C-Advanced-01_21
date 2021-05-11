using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_M_M
{
    public class Projects
    {
        public int Id { get; set; }
        public string Project_name { get; set; }
        public ICollection<Person> Person { get; set; }
        public ICollection<Phone> Phone { get; set; }

        public Projects()
        {
            Person = new List<Person>();
            Phone = new List<Phone>();
        }

    }
}
