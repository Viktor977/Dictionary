using Dictionary.Bal.Interfaces;
using Dictionary.Bal.Services;
using Dictionary.Dal.Access;
using Microsoft.Extensions.DependencyInjection;

namespace Dictionary.Bal.Access
{
    public class DictionaryDIConfigurationBal
    {
        public static void Configuration(IServiceCollection service)
        {
            DictionaryDIConfiguratuinDal.Configurations(service);
            service.AddScoped<IWordService,WordService>();
            service.AddScoped<IUkrWordService,UkrWordService>();
            service.AddScoped<IEngWordService,EngWordService>();
            var profile = new AutoMapperProfile();
            service.AddSingleton(profile.GetMapper());
        }
    }
}
