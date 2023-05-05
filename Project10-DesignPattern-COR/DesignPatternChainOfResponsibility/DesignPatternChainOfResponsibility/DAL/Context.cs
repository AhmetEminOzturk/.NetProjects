using Microsoft.EntityFrameworkCore;

namespace DesignPatternChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OQD43KV\\SQLEXPRESS; initial catalog=ChainOfRespDb; integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
