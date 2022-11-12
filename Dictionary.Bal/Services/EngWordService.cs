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

        public async Task Add(EnglishWordDto model)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(model);
            _unitOfWork.EnglishWordRepository.Add(word);
           await _unitOfWork.SaveAsync();
        }

        public async Task Delete(EnglishWordDto model)
        {
           var word=_mapper.Map<EnglishWordDto,EnglishWord>(model);
            _unitOfWork.EnglishWordRepository.Delete(word);
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(EnglishWordDto model)
        {
            var word = _mapper.Map<EnglishWordDto, EnglishWord>(model);
            _unitOfWork.EnglishWordRepository.Update(word);
            await _unitOfWork.SaveAsync();
        }
    }
}
