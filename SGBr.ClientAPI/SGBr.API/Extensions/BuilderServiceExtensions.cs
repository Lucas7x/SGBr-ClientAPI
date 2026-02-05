using Microsoft.EntityFrameworkCore;
using SGBr.Infrastrucure.Database;

namespace SGBr.API.Extensions
{
    public static class BuilderServiceExtensions
    {
        public static IServiceCollection ConfigureDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            string? defaultConnection = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(defaultConnection))
                throw new ArgumentNullException(nameof(defaultConnection));

            services.AddDbContext<DataContext>(
                options => options.UseSqlite(defaultConnection)
            );

            return services;
        }

        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<DataContext>();
            db.Database.Migrate();
            return app;
        }
    }
}
