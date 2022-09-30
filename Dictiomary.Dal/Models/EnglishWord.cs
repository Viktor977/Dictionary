using System;
using System.Collections.Generic;

namespace Dictionary.Dal.Models
{
    public class EnglishWord : BaseEntity
    {
        public string Word { get; set; }  
        public virtual ICollection<Word> UkranianWords { get; set; }

        public EnglishWord() =>UkranianWords = new HashSet<Word>();
    }
}
