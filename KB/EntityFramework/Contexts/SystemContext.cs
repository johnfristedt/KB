using KB.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KB.EntityFramework.Contexts
{
    public class SystemContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}