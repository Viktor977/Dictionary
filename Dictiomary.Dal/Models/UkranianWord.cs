using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Models
{
    public class UkranianWord : BaseEntity
    {
        public string Word { get; set; }
        public ICollection<Word> EnglishWords { get; set; }
    }
}
