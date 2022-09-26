using Dictionary.Bal.Interfaces;
using Dictionary.Bal.Services;
using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Access
{
    public class DictionaryDIConfigurationBal
    {
        public static void Configuration(IServiceCollection service)
        {
            DictionaryDIConfiguratuinDal.Configurations(service);
            service.AddScoped<IEnglishWordService, EnglishWordService>();
            service.AddScoped<IUkranianWordService,UkranianWordService>();
            var profile = new AutoMapperProfile();
            service.AddSingleton(profile.GetMapper());
        }
    }
}
