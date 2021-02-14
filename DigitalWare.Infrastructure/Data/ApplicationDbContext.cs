using DigitalWare.Core.Entities;
using DigitalWare.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DigitalWare.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }
}