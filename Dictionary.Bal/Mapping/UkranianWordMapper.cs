using AutoMapper;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;

namespace Dictionary.Bal.Mapping
{
    public class UkranianWordMapper : Profile
    {
        public UkranianWordMapper()
        {
            CreateMap<UkranianWord, UkranianWordDto>().ReverseMap();
        }
    }
}
