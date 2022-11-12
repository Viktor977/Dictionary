using Dictiomary.Dal.Repositories;
using Dictionary.Bal.ModelsDto;
using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Tests.DataTests
{
    public class WordRepositoryTest
    {
        [Test]
        public async Task WordRepositoryTest_GetAllAsync_ReturnCount()
        {
            //Arrang
            var wordDb = new DictionaryDbContext(UnitTestHelper.GetUnitDbOptions());
            var repository = new WordRepository(wordDb);
            const int actual = 7;

            //Act
            //var expected = await repository.GetAllAsync();
            //var expcount=expected.Count();

            //Assert
          //  Assert.AreEqual(expcount, actual);

        }

        [Test]
        public async Task WordRepositoryTest_GetEngWords_ReturnUkrWords()
        {

        }

        private static IEnumerable<UkranianWordDto> expectedUkrWordsDto =>
         new[]
         {
            new UkranianWordDto() { Id = 4, Word = "Тест чотири" },
            new UkranianWordDto() { Id = 5, Word = "Тест п'ять" }
         };
    }
}
