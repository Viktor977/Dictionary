using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Dictionary.Dal.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Tests.DataTests
{
    public class EnglishWordRepositoryTests
    {
        [Test]
        public void GetWord_ReturnUkrWords()
        {
            //Arrange
            var wordDb = new DictionaryDbContext(UnitTestHelper.GetUnitDbOptions());
            var repository = new EnglishWordRepository(wordDb);

            //Act
            var words = repository.GetUkranianWords("TestOne");

            //Assert
            Assert.That(words,Is.EqualTo( expectedUkrWords).Using(new UkranianWordQualityCompare()),
                message:"GetUkranianWords method work incorect");

        }

        private static IEnumerable<UkranianWord> expectedUkrWords =>
        new[]
        {
            new UkranianWord() { Id = 1, Word = "Тестодин"},
            new UkranianWord() { Id = 2, Word = "Тестдва" },
            new UkranianWord(){  Id = 3, Word = "Тесттри"  }
        };
    }
}
