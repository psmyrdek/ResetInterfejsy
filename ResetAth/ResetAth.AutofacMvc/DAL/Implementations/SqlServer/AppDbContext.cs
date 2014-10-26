using ResetAth.AutofacMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResetAth.AutofacMvc.DAL.Implementations.SqlServer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("SqlServerContext")
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}