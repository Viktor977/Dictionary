using Dictiomary.Dal.Interfaces;
using Dictiomary.Dal.Repositories;
using Dictionary.Dal.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Dictionary.Dal.Access
{
    public  class DictionaryDIConfiguratuinDal
    {
        public static  void Configurations(IServiceCollection services)
        {
            services.AddScoped<DictionaryDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IWordRepository, WordRepository>();
        }
    }
}
