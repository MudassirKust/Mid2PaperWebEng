using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MudassirMVC.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
            public string School_Name { get; set; }
        public string Address { get; set; }
        public int Classes { get; set; }
        public int Staff { get; set; }
    }

    public class SchoolDBContext : DbContext
    {
        public DbSet<School> School { get; set; }
    }
}