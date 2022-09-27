using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Bal.ModelsDto
{
    public class WordDto
    {
        public EnglishWordDto EnglishWordDto { get; set; }
        public IEnumerable<UkranianWordDto> UkranianWordsDto { get; set; }
    }
}
