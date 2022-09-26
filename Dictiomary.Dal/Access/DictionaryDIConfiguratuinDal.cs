using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dictionary.Dal.Access
{
    public  class DictionaryDIConfiguratuinDal
    {
        public static  void Configurations(IServiceCollection services)
        {
            services.AddTransient<DictionaryDbContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUkranianWordRepository, UkrainianWordRepository>();
            services.AddTransient<IEnglishWordRepository, EnglishWordRepository>();
        }
    }
}
