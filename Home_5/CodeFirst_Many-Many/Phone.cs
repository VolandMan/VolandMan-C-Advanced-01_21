using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_M_M
{
    public class Phone
    {
        public int? Id { get; set; }
        public string Namber { get; set; }
        public ICollection<Projects> Project_names { get; set; }
        public Phone()
        {
            Project_names = new List<Projects>();
        }
    }
}
