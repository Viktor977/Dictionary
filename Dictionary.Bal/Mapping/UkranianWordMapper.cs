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
    public class UkranianWordMapper : Profile
    {
        public UkranianWordMapper()
        {
            CreateMap<UkranianWord, UkranianWordDto>().ReverseMap();
        }
    }
}
