using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WL.Core.Base.Interface;
using WL.Data.Contexts;
using WL.Data.Repositories.EF;

namespace WL.Data;

public static class DependencyInstallerData
{
    public static IServiceCollection AddDataDependencies(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DefaultContext>(options => 
        {
            options.UseNpgsql(connectionString);
        });

        services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        return services;
    }
}
