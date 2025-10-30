using Infrastructure.Contexts;
using Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Extensions
{
    public static class HostExtensions
    {
        public static void SeedDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();

                DbInitializer.Initialize(context);
            }
        }
    }
}
