using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Tests
{
    internal class EnglishWordQualityCompare : IEqualityComparer<EnglishWord>
    {
        public bool Equals([AllowNull]EnglishWord x, [AllowNull] EnglishWord y)
        {
            if(x == null || y == null)return false;
            if(x==null && y==null)return true;
            return x.Id== y.Id
                && x.Word==y.Word;
        }
       
        public int GetHashCode([DisallowNull] EnglishWord obj)
        {
            return obj.GetHashCode();
        }
    }
}
