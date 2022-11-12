using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Repositories
{
    public class EnglishWordRepository : RepositoryBase<EnglishWord>,IEnglishWordRepository
    {
        public EnglishWordRepository(DictionaryDbContext context) : base(context) { }   
    }
}
