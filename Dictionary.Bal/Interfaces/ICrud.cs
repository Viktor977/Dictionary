﻿using Dictionary.Bal.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.Interfaces
{
    public interface ICrud<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<IEnumerable<TModel>> GetByIdAsync(int id);
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
    }
}
