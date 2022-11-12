using Dictionary.Dal.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dictionary.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCorse(this IServiceCollection services)=>
        
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            
            });

        public static void SqlConfiguration(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<DictionaryDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("wordDB")));
        
    }
}
