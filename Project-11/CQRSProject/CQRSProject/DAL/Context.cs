using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OQD43KV\\SQLEXPRESS; initial catalog= CQRSProjectDb; integrated security=true;");
        }
        public DbSet<Product> Products{ get; set; }
    }
}
