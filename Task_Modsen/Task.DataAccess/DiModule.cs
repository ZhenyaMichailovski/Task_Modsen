using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Task.DataAccess.Interfaces;
using Task.DataAccess.Repository;

namespace Task.DataAccess
{
    public static class DiModule
    {
        public static void ConfigurateDalServices(this IServiceCollection builder, string _connectionString)
        {
            builder.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(_connectionString));

            builder.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            builder.AddScoped<DbContext, ApplicationContext>();
        }
    }
}
