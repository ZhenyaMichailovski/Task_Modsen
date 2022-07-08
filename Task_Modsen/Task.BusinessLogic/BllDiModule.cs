using Microsoft.Extensions.DependencyInjection;
using Task.BusinessLogic.Interfaces;
using Task.BusinessLogic.Services;
using Task.DataAccess;

namespace Task.BusinessLogic
{
    public static class BllDiModule
    {
        public static void ConfigurateBllManagers(this IServiceCollection service, string _connectionString)
        {
            service.ConfigurateDalServices(_connectionString);
            service.AddScoped<IEventService, EventService>();
        }
    }
}
