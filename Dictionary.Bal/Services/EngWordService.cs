using AutoMapper;
using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Services
{
    public class EngWordService : IEngWordService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public EngWordService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(WordDto model)
        {
            var wordE = _mapper.Map<EnglishWordDto, EnglishWord>(model.EnglishWordDto);
            var wordU = _mapper.Map<UkranianWordDto, UkranianWord>(model.UkranianWordDto);


            _unitOfWork.EnglishWordRepository.Add(wordE);
            var wordEId = _unitOfWork.EnglishWordRepository
                .GetEnglishWord(model.EnglishWordDto.Word);

            _unitOfWork.UkranianWordRepository.Add(wordU);
            var wordUId = _unitOfWork.UkranianWordRepository
                .GetUkranianWord(model.UkranianWordDto.Word);

            var word = new Word
            {
                EngId = wordE.Id,
                EnglishWord = wordE,
                UkrId = wordU.Id,
                UkranianWord = wordU
            };

            _unitOfWork.WordRepository.Add(word);

            await _unitOfWork.SaveAsync();
        }

        public async Task Delete(WordDto model)
        {
            //TODO
            var wordE = _mapper.Map<EnglishWordDto, EnglishWord>(model.EnglishWordDto);
            var wordU = _mapper.Map<UkranianWordDto, UkranianWord>(model.UkranianWordDto);
            var word = _mapper.Map<WordDto, Word>(model);

            _unitOfWork.EnglishWordRepository.Delete(wordE);
            _unitOfWork.UkranianWordRepository.Delete(wordU);
            _unitOfWork.WordRepository.Delete(word);

            await _unitOfWork.SaveAsync();
        }

        public IEnumerable<UkranianWordDto> GetUkrWords(EnglishWordDto wordDto)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(wordDto);
            var ukrWords = _unitOfWork.EnglishWordRepository.GetUkranianWords(word.Word);
            if (ukrWords == null) return null;
            var words = _mapper.Map<IEnumerable<UkranianWord>, IEnumerable<UkranianWordDto>>(ukrWords);
            return words;
        }

        public async Task Update(WordDto model)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(model.EnglishWordDto);
            _unitOfWork.EnglishWordRepository.Update(word);
            await _unitOfWork.SaveAsync();
        }
    }
}
