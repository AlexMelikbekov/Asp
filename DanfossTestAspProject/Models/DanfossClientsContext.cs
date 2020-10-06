using Microsoft.EntityFrameworkCore;

namespace DanfossTestAspProject.Models
{
    public class DanfossClientsContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<SpecialOffer> SpecialOffer { get; set; }

        /// <summary>
        /// Create the database on the first call.
        /// </summary>
        /// <param name="options"></param>
        public DanfossClientsContext(DbContextOptions<DanfossClientsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
