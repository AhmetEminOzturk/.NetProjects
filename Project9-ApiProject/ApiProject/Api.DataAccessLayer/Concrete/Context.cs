using Api.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OQD43KV\\SQLEXPRESS;initial catalog=DbApi;integrated Security=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
