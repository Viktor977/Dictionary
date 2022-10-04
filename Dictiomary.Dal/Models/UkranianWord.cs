using System.Collections.Generic;

namespace Dictionary.Dal.Models
{
    public class UkranianWord : BaseEntity
    {
        public string Word { get; set; }
        public  ICollection<Word> EnglishWords { get; set; }
        public UkranianWord() => EnglishWords = new HashSet<Word>();
    }
}
