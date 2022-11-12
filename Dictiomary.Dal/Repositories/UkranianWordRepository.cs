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
    public class UkranianWordRepository : RepositoryBase<UkranianWord>,IUkranianWordRepository
    {
        public UkranianWordRepository(DictionaryDbContext context):base(context) { }
    }
}
