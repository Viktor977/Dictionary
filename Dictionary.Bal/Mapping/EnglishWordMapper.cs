using AutoMapper;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;

namespace Dictionary.Bal.Mapping
{
    public class EnglishWordMapper : Profile
    {
        public EnglishWordMapper()
        {
            CreateMap<EnglishWord,EnglishWordDto>().ReverseMap();         
        }
    }
}
