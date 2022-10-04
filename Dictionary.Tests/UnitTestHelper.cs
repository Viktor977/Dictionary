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
            var eword1 = new EnglishWord() { Id=1, Word = "TestOne" };
            var eword2 = new EnglishWord() { Id = 2, Word = "TestTwo" };
            var eword3 = new EnglishWord() { Id = 3, Word = "Testthree" };
            var eword4 = new EnglishWord() { Id = 4, Word = "TestFour" };
            var eword5 = new EnglishWord() { Id = 5, Word = "TestFive" };
            var eword6 = new EnglishWord() { Id = 6, Word = "TestSix" };

            //ukranian words

            var uword1 = new UkranianWord() { Id = 1, Word = "Тестодин" };
            var uword2 = new UkranianWord() { Id = 2, Word = "Тестдва" };
            var uword3 = new UkranianWord() { Id = 3, Word = "Тесттри" };
            var uword4 = new UkranianWord() { Id = 4, Word = "Тестчотири" };
            var uword5 = new UkranianWord() { Id = 5, Word = "Тестп'ять" };
            var uword6 = new UkranianWord() { Id = 6, Word = "Тестшість" };
               
            var wordsone = new Word() { 
                Id = 1,
                EngId = eword1.Id, EnglishWord = eword1,
                UkrId = uword1.Id, UkranianWord = uword1 
            };

            var wordtwo = new Word() { 
                Id = 2, 
                EngId = eword1.Id, EnglishWord = eword1,            
                UkrId = uword2.Id, UkranianWord = uword2              
            };

            var wordsthree = new Word() 
            { 
                Id = 3,
                EngId = eword1.Id,  EnglishWord = eword1,             
                UkrId = uword3.Id,  UkranianWord = uword3             
            };
          
            var wordsfour = new Word()
            {
                Id = 4, 
                EngId = eword2.Id, EnglishWord = eword2,             
                UkrId = uword4.Id, UkranianWord = uword4             
            };

            var wordsfive = new Word()
            {
                Id = 5,
                EngId = eword3.Id, EnglishWord = eword3,             
                UkrId = uword4.Id, UkranianWord = uword4              
            };
           
            var wordssix = new Word()
            {
                Id = 6, 
                EngId = eword4.Id,  EnglishWord = eword4,            
                UkrId = uword4.Id,UkranianWord = uword4               
            };

            var wordsseven = new Word() 
            {
                Id = 7, 
                EngId = eword5.Id, EnglishWord = eword5,              
                UkrId = uword5.Id, UkranianWord = uword5
            };

            context.Ukranians.AddRange(uword1);
            context.Ukranians.AddRange(uword2);
            context.Ukranians.AddRange(uword3);
            context.Ukranians.AddRange(uword4);
            context.Ukranians.AddRange(uword5);
            context.Ukranians.AddRange(uword6);

            context.Englishes.AddRange(eword1);
            context.Englishes.AddRange(eword2);
            context.Englishes.AddRange(eword3);
            context.Englishes.AddRange(eword4);
            context.Englishes.AddRange(eword5);
            context.Englishes.AddRange(eword6);

            context.Words.AddRange(wordsone);
            context.Words.AddRange(wordtwo);
            context.Words.AddRange(wordsthree);
            context.Words.AddRange(wordsfour);
            context.Words.AddRange(wordsfive);
            context.Words.AddRange(wordssix);
            context.Words.AddRange(wordsseven);

            context.SaveChanges();
        }
    }
}