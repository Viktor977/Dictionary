using AutoMapper;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;


namespace Dictionary.Bal.Mapping
{
    public class WordsMapper : Profile
    {
        public WordsMapper()
        {
            CreateMap<WordDto, Word>().ReverseMap();             
        }
    }
}
