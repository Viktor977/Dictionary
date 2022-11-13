﻿using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary.Dal.Repositories
{
    public class EnglishWordRepository : RepositoryBase<EnglishWord>,IEnglishWordRepository
    {
        private readonly DictionaryDbContext _context;
        public EnglishWordRepository(DictionaryDbContext context) : base(context) =>_context = context;

        public IEnumerable<UkranianWord> GetUkranianWords(string engWord)
        {
            var words = _context.Words
                .Where(t => t.EnglishWord.Word == engWord)
                .Select(t => t.UkranianWord);
            return words;            
        }
    }
}
