using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Entity;

namespace RepositoryPatternExp.Models
{
    public class ReoPDbEntities : DbContext
    {
        public ReoPDbEntities()
              : base("name=Conn")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ReoPDbEntities>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<StudentDetails> StudentDetailss { get; set; }
    }
}