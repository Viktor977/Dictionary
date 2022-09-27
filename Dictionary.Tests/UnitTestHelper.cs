using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace Dictionary.Tests
{
    public class UnitTestHelper
    {
        public static DbContextOptions<DictionaryDbContext> GetUnitDbOptions()
        {

            var options = new DbContextOptionsBuilder<DictionaryDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
                
            using (var context = new DictionaryDbContext(options))
            {
                SeedData(context);
            }

            return options;

        }

        public static void SeedData(DictionaryDbContext context)
        {
            //english words
            var eword1 = new EnglishWord() { Id = 1, Word = "Test One" };
            var eword2 = new EnglishWord() { Id = 2, Word = "Test Two" };
            var eword3 = new EnglishWord() { Id = 3, Word = "Test Three" };

            //ukranian words

            var uword1 = new UkranianWord() { Id = 1, Word = "Тест один" };
            var uword2 = new UkranianWord() { Id = 2, Word = "Тест два" };
            var uword3 = new UkranianWord() { Id = 3, Word = "Тест три" };

            var wordsone = new Word() { Id = 1, EngId = 1, EnglishWord = eword1, UkrId = 1, UkranianWord = uword1 };
            var wordtwo = new Word() { Id = 2, EngId = 2, EnglishWord = eword2, UkrId = 2, UkranianWord = uword2 };
            var wordsthree = new Word() { Id = 3, EngId = 3, EnglishWord = eword3, UkrId = 3, UkranianWord = uword3 };

            context.Ukranians.AddRange(uword1);
            context.Ukranians.AddRange(uword2);
            context.Ukranians.AddRange(uword3);

            context.Englishes.AddRange(eword1);
            context.Englishes.AddRange(eword2);
            context.Englishes.AddRange(eword3);

            context.Words.AddRange(wordsone);
            context.Words.AddRange(wordtwo);
            context.Words.AddRange(wordsthree);

            context.SaveChanges();
        }
    }
}