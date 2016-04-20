using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyContext : DbContext
    {
        public MyContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DavidsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") {
            // min kod
        }

        public DbSet<Class1> Example { get; set; }
    }
}
