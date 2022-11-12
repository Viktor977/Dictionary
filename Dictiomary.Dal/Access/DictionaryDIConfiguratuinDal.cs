using Dictiomary.Dal.Interfaces;
using Dictiomary.Dal.Repositories;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Repositories;
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
            services.AddScoped<IEnglishWordRepository, EnglishWordRepository>();
            services.AddScoped<IUkranianWordRepository, UkranianWordRepository>();
        }
    }
}
