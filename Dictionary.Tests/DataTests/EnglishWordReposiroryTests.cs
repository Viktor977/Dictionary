using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Dictionary.Dal.Repositories;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var eword = new EnglishWord() { Word = "Test Foure"};     
            int actual = 4;

            //Act
            await repository.AddAsync(eword);
            await wordDb.SaveChangesAsync();
            var expected = wordDb.Englishes.Count();

            //Assert
            Assert.AreEqual(actual,expected);

        }

        [Test]
        public async Task EnglishWordRepositoryTest_Delete()
        {
           // var wordDb = new DictionaryDbContext(UnitTestHelper.GetUnitDbOptions());
        }

        [Test]
        public async Task EnglishWordRepositoryTest_Update()
        {

        }

        [Test]
        public async Task EnglishWordRepositoryTest_GetAll()
        {

        }

        [Test]
        public async Task EnglishWordRepositoryTest_GetWord()
        {

        }

        IEnumerable<EnglishWord> testEWords =>
            new[]
            {
                new EnglishWord(){Id=1,Word="testOne"},
                new EnglishWord(){Id=2,Word="testTwo"},

            };
        IEnumerable<UkranianWord> testUWords =>
            new[]
            {
                new UkranianWord(){Id=1,Word="тестОдин"},
                new UkranianWord(){Id=1,Word="тестДва"}
            };
        ICollection<Word> words =>
            new[]
            {
                new Word()
                {
                    UkranianWord=testUWords.FirstOrDefault(t=>t.Id == 1),
                    EnglishWord=testEWords.FirstOrDefault(t=>t.Id == 1)
                },
                new Word()
                {
                    UkranianWord=testUWords.FirstOrDefault(t=>t.Id == 2),
                    EnglishWord=testEWords.FirstOrDefault(t=>t.Id == 1)
                }
            };
    }
}
