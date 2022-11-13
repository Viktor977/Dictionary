using System;

namespace Dictionary.Dal.Models
{
    public class Word 
    {
        public int Id { get; set; }
        public int EngId { get; set; }
        public EnglishWord EnglishWord { get; set; }
        public int UkrId { get; set; }
        public UkranianWord UkranianWord { get; set; }

    }
}
