using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IUnitOfWork
    {
        IUkranianWordRepository UkranianWordRepository { get; }
        IEnglishWordRepository EnglishWordRepository { get; }
        Task SaveAsync();
    }
}
