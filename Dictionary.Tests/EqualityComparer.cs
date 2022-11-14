using Dictionary.Dal.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Dictionary.Tests
{
    internal class EnglishWordQualityCompare : IEqualityComparer<EnglishWord>
    {
        public bool Equals([AllowNull]EnglishWord x, [AllowNull] EnglishWord y)
        {
            if(x == null || y == null)return false;
            if(x==null && y==null)return true;
            return x.Id == y.Id
                && x.Word == y.Word
                && x.Examples == y.Examples;
        }
       
        public int GetHashCode([DisallowNull] EnglishWord obj)
        {
            return obj.GetHashCode();
        }
    }

    internal class UkranianWordQualityCompare : IEqualityComparer<UkranianWord>
    {
        public bool Equals([AllowNull] UkranianWord x, [AllowNull] UkranianWord y)
        {
            if (x == null || y == null) return false;
            if (x == null && y == null) return true;
            return x.Id == y.Id
                && x.Word == y.Word
                && x.Examples == y.Examples;
        }

        public int GetHashCode([DisallowNull] UkranianWord obj)
        {
            return obj.GetHashCode();
        }
    }
}
