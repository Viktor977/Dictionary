using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Dictionary.Dal.Repositories;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary.Tests.DataTests
{
    public class EnglishWordReposiroryTests
    {
        [Test]
        public async  Task EglishWordRepositoryTest_AddWord()
        {
            //Arrang
            using var wordDb = new DictionaryDbContext(UnitTestHelper.GetUnitDbOptions());
            var repository=new EnglishWordRepository(wordDb);
            var eword = new EnglishWord() { Word = "Test Foure" };
            var uword = new UkranianWord() { Word = "Тест чотири" };
            int actual = 4;

            //Act
            repository.Create(eword);
            await wordDb.SaveChangesAsync();
            var expected = wordDb.Englishes.Count();

            //Assert
            Assert.AreEqual(actual,expected);

        }     
    }
}
