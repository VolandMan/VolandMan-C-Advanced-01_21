using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace CodeFirst_M_M
{
    public class ManyToManyEntity : DbContext
    {
   
        public ManyToManyEntity()
            : base("name=ManyToManyEntity")
        {
        }


         public virtual DbSet<Person> PersonEntity { get; set; }
         public virtual DbSet<Projects> ProjectEntity { get; set; }
         public virtual DbSet<Phone> Phone { get; set; }

    }
}