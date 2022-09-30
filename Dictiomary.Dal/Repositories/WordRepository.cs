﻿using Dictiomary.Dal.Interfaces;
using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictiomary.Dal.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly DictionaryDbContext _context;
        public WordRepository(DictionaryDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Word entity)
        {
            await _context.Words.AddAsync(entity);
        }

        public void Delete(Word entity)
        {
           _context.Remove(entity);
        }

        public async Task<IEnumerable<Word>> GetAllAsync()
        {
            return await _context.Words
                 .Include(t => t.UkranianWord)
                 .Include(t => t.EnglishWord)
                 .ToListAsync();
        }

        public void Update(Word entity)
        {
            _context.Update(entity);
        }
    }
}