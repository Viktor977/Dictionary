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
            var profile = new AutoMapperProfile();
            service.AddSingleton(profile.GetMapper());
        }
    }
}
