using AutoMapper;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Mapping
{
    public class WordsMapper : Profile
    {
        public WordsMapper()
        {
            CreateMap<WordDto, Word>();
                //.ForMember(dest => dest.UkranianWords,
                //act => act.MapFrom(t => t.UkranianWordsDto))
                //.ForMember(dest => dest.Word,
                //act => act.MapFrom(t => t.EnglishWordDto));
                
        }
    }
}
