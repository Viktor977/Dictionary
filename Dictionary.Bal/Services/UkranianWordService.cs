using AutoMapper;
using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Services
{
    public class UkranianWordService : IUkranianWordService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;
        public UkranianWordService(IUnitOfWork work, IMapper mapper)
        {
            _work = work;
            _mapper = mapper;
        }   

        public void  Add(UkranianWordDto model)
        {
            var word = _mapper.Map<UkranianWordDto, UkranianWord>(model);
             _work.UkranianWordRepository.Create(word);
        }

        public void Delete(UkranianWordDto model)
        {
           var word=_mapper.Map<UkranianWordDto, UkranianWord>(model);
          _work.UkranianWordRepository.Delete(word);
        }

        public async Task<IEnumerable<UkranianWordDto>> GetAllAsync()
        {
            var mapwords = await _work.UkranianWordRepository.GetAllAsync();
            var words=_mapper.Map<IEnumerable<UkranianWord>,IEnumerable < UkranianWordDto >> (mapwords);
            return words;
        }

        public  async Task<UkranianWordDto> GetByIdAsync(int id)
        {
            var mapword =await _work.UkranianWordRepository.GetByIdAsync(id);
            var word = _mapper.Map<UkranianWord, UkranianWordDto>(mapword);
            return word;
        }

        public void Update(UkranianWordDto model)
        {
            var word = _mapper.Map<UkranianWordDto, UkranianWord>(model);
            _work.UkranianWordRepository.Update(word);
        }
    }
}
