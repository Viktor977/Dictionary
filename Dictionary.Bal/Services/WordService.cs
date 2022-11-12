using AutoMapper;
using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Services
{
    public class WordService : IWordService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public WordService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(WordDto model)
        {
            var word = _mapper.Map<Word>(model);
            _unitOfWork.WordRepository.Add(word);
            await _unitOfWork.SaveAsync();
        }

        public async Task Delete(WordDto model)
        {
            var word = _mapper.Map<Word>(model);
            _unitOfWork.WordRepository.Delete(word);
            await _unitOfWork.SaveAsync();
        }

        public IEnumerable<WordDto> GetByCondition(WordDto model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WordDto> GetEngWords(UkranianWordDto ukranianWordDto)
        {
            //var word = _mapper.Map<UkranianWord>(ukranianWordDto);
            //var words = _unitOfWork.WordRepository.GetByCondition(() => { word});
            //return words;
            throw new NotImplementedException();
        }

        public IEnumerable<WordDto> GetUkrWords(EnglishWordDto englishWordDto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(WordDto model)
        {
            var word = _mapper.Map<Word>(model);
            _unitOfWork.WordRepository.Update(word);
            await _unitOfWork.SaveAsync();
        }
    }
}
