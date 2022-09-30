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

        public async Task AddEngWord(WordDto wordDto)
        {
            var word=_mapper.Map<WordDto,Word>(wordDto);
            await _unitOfWork.WordRepository.AddAsync(word);
            await _unitOfWork.SaveAsync();
        }
        public async Task<IEnumerable<UkranianWordDto>> GetUkrWords(string word)
        {
            var words = await _unitOfWork.WordRepository.GetAllAsync();
            var ukwords = words.Where(t => t.EnglishWord.Word == word)
                .Select(t => t.UkranianWord);
            var ukwordsDto = _mapper.Map<IEnumerable<UkranianWord>,
                IEnumerable<UkranianWordDto>>(ukwords);

            return ukwordsDto;

        }

        public async Task<IEnumerable<EnglishWordDto>> GetEngWords(string word)
        {
            var words = await _unitOfWork.WordRepository.GetAllAsync();
            var enwords = words.Where(t => t.UkranianWord.Word == word)
                .Select(t => t.EnglishWord);
            var enwordsDto = _mapper.Map<IEnumerable<EnglishWord>,
                IEnumerable<EnglishWordDto>>(enwords);

            return enwordsDto;

        }
    }
}
