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
    public class EnglishWordMapper : Profile
    {
        public EnglishWordMapper()
        {
            CreateMap<EnglishWord, EnglishWordDto>()
                .ForMember(t => t.Word, r => r.MapFrom(r => r.Word))
                .ForMember(t => t.UkranianWordsDto, r => r.MapFrom(t => t.UkranianWords
                .Select(x=>x.UkranianWord).ToList()));
                
            CreateMap<EnglishWordDto, EnglishWord>()
                .ForMember(t=>t.Word, r => r.MapFrom(r => r.Word))
                .ForMember(t=>t.UkranianWords,r=>r.MapFrom(x=>x.UkranianWordsDto
                .Select(x=>x.Word)));
          
        }
    }
}
