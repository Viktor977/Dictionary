using System;
using System.Collections.Generic;

namespace Dictionary.Dal.Models
{
    public class EnglishWord : BaseEntity
    {  
        public  ICollection<Word> Words { get; set; }
        public EnglishWord() => Words = new HashSet<Word>();
    }
}
