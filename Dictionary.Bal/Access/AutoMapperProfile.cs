using AutoMapper;
using Dictionary.Bal.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Access
{
    public class AutoMapperProfile : Profile
    {
        public IMapper GetMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<EnglishWordMapper>();
                config.AddProfile<UkranianWordMapper>();
                config.AddProfile<WordsMapper>();
            });
            var profile = configuration.CreateMapper();

            return profile;
        }
    }
}
