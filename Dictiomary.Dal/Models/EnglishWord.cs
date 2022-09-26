using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Models
{
    public class EnglishWord : BaseEntity
    {
        public string Word { get; set; }  
        public ICollection<Word> UkranianWords { get; set; }

    }
}
