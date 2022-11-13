using System.Collections.Generic;

namespace Dictionary.Dal.Models
{
    public class UkranianWord : BaseEntity
    {       
        public  ICollection<Word> Words { get; set; }
        public UkranianWord() => Words = new HashSet<Word>();
    }
}
