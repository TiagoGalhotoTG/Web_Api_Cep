using Api.Data.Context;
using Api.Data.Implementantions;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
         public static void ConfigureDependeciesRepository (IServiceCollection serviceCollection)
         {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddDbContext<MyContext>
            (options => options.UseMySql 
            ("Server=localhost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=36046098"));
         }
    }
}