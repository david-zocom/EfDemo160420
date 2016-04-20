using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.Model
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base("Hogwarts") { }

        public DbSet<Student> Students { get; set; }
    }
}
