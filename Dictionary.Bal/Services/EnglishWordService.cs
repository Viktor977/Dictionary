using AutoMapper;
using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Bal.Services
{
    public class EnglishWordService : IEnglishWordService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public EnglishWordService(IUnitOfWork work, IMapper mapper)
        {
            _work = work;
            _mapper = mapper;
        }

        public  void Add(EnglishWordDto model)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(model);
            _work.EnglishWordRepository.Create(word);
           
        }

        public  void Delete(EnglishWordDto model)
        {
            var word=_mapper.Map<EnglishWordDto,EnglishWord>(model);
            _work.EnglishWordRepository.Delete(word);
           
        }

        public  async Task<IEnumerable<EnglishWordDto>> GetAllAsync()
        {
            var mapwords = await _work.EnglishWordRepository.GetAllAsync();
            var words=_mapper.Map<IEnumerable<EnglishWord>,IEnumerable<EnglishWordDto>> (mapwords);
            return   words;
        }

        public async Task<EnglishWordDto>GetByIdAsync(int id)
        {
            var mapword= await _work.EnglishWordRepository.GetByIdAsync(id);
            var word= _mapper.Map<EnglishWord,EnglishWordDto>(mapword);
            return word;
        }

        public  void Update(EnglishWordDto model)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(model);
            _work.EnglishWordRepository.Update(word);
           
        }
    }
}
