using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class BookContext:DbContext
    {
        public BookContext():base("name=Bookcontext")
        { }

        //include all models as DbSet Objects
        public DbSet<Book> Books { get; set; }
        public DbSet<Publishers> Publisher { get; set; }
        public DbSet<Authors> Author { get; set; }

        
    }
}
