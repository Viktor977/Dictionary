﻿using Dictionary.Dal.Access;
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
            var eword4 = new EnglishWord() { Id = 4, Word = "Test Four" };
            var eword5 = new EnglishWord() { Id = 5, Word = "Test Five" };
            var eword6 = new EnglishWord() { Id = 6, Word = "Test Six" };

            //ukranian words

            var uword1 = new UkranianWord() { Id = 1, Word = "Тест один" };
            var uword2 = new UkranianWord() { Id = 2, Word = "Тест два" };
            var uword3 = new UkranianWord() { Id = 3, Word = "Тест три" };
            var uword4 = new UkranianWord() { Id = 4, Word = "Тест чотири" };
            var uword5 = new UkranianWord() { Id = 5, Word = "Тест п'ять" };
            var uword6 = new UkranianWord() { Id = 6, Word = "Тест шість" };
               
            var wordsone = new Word() { Id = 1, EngId = 1, EnglishWord = eword1, UkrId = 1, UkranianWord = uword1 };
            var wordtwo = new Word() { Id = 2, EngId = 2, EnglishWord = eword2, UkrId = 2, UkranianWord = uword2 };
            var wordsthree = new Word() { Id = 3, EngId = 3, EnglishWord = eword3, UkrId = 3, UkranianWord = uword3 };
            //eng 'Test Four'->ukr 'Тест чотири' and 'Тест п`ять '
            var wordsfour = new Word() { Id = 4, EngId = 4, EnglishWord = eword4, UkrId = 4, UkranianWord = uword4 };
            var wordsfive = new Word() { Id = 5, EngId = 4, EnglishWord = eword4, UkrId = 5, UkranianWord = uword5 };
            //ukr 'Тест шість'->eng 'Test Five' and 'Test Six'
            var wordssix = new Word() { Id = 6, EngId = 5, EnglishWord = eword4, UkrId = 6, UkranianWord = uword5 };
            var wordsseven = new Word() { Id = 7, EngId = 6, EnglishWord = eword4, UkrId = 6, UkranianWord = uword5 };

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