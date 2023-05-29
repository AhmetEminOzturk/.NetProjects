using Microsoft.EntityFrameworkCore;

namespace AkademiPlus_Ajax.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OQD43KV\\SQLEXPRESS;initial catalog=AkademiAjaxDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
