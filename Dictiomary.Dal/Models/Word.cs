using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Models
{
    public class Word : BaseEntity
    {
        public int EngId { get; set; }
        public EnglishWord EnglishWord { get; set; }
        public int UkrId { get; set; }
        public UkranianWord UkranianWord { get; set; }

    }
}
