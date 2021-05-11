using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst
{
    public class OneToManyDbEntity : DbContext
    {

        public OneToManyDbEntity()
            : base("name=OneToManyDbEntity")
        {
        }

         public virtual DbSet<Person> PersonEntities { get; set; }
         public virtual DbSet<Phone> PhoneEntities { get; set; }

    }

}