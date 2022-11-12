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
    public class UkrWordService : IUkrWordService
    {
        private readonly IMapper _maper;
        private readonly IUnitOfWork _unitOfWork;
        public UkrWordService(IMapper maper, IUnitOfWork unitOfWork)
        {
            _maper = maper;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(UkranianWordDto model)
        {
          var word=_maper.Map<UkranianWord>(model);
            _unitOfWork.UkranianWordRepository.Add(word);
            await _unitOfWork.SaveAsync();

        }

        public async Task Delete(UkranianWordDto model)
        {
            var word = _maper.Map<UkranianWord>(model);
            _unitOfWork.UkranianWordRepository.Delete(word);
            await _unitOfWork.SaveAsync();
        }


        public async Task Update(UkranianWordDto model)
        {
            var word = _maper.Map<UkranianWord>(model);
            _unitOfWork.UkranianWordRepository.Update(word);
            await _unitOfWork.SaveAsync();
        }
    }
}
