using Microsoft.EntityFrameworkCore;
using SGBr.Domain.Entities;

namespace SGBr.Infrastrucure.Database
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
    }
}
