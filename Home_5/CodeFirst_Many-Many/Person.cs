using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_M_M
{
    public class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public ICollection<Projects> Project_names { get; set; }

        public Person()
        {
            Project_names = new List<Projects>();
        }
    }
}
