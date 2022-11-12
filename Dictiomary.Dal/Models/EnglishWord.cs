using System;
using System.Collections.Generic;

namespace Dictionary.Dal.Models
{
    public class EnglishWord : BaseEntity
    {  
        public  ICollection<Word> UkranianWords { get; set; }
        public EnglishWord() =>UkranianWords = new HashSet<Word>();
    }
}
