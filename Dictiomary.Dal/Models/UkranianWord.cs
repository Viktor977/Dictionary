using Microsoft.VisualBasic;
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
        public virtual ICollection<Word> EnglishWords { get; set; }
        public UkranianWord()=>EnglishWords = new HashSet<Word>();
    }
}
