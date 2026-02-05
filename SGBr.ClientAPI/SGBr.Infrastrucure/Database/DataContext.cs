using Microsoft.EntityFrameworkCore;
using SGBr.Domain.Entities;

namespace SGBr.Infrastrucure.Database
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}
