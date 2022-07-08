using Microsoft.Extensions.DependencyInjection;
using Task.BusinessLogic.Interfaces;
using Task.BusinessLogic.Services;

namespace Task.BusinessLogic
{
    public static class BllDiModule
    {
        public static void ConfigurateBllManagers(IServiceCollection service, string _connectionString)
        {
            DataAccess.DiModule.ConfigurateDalServices(service, _connectionString);
            service.AddScoped<IEventService, EventService>();
        }
    }
}
