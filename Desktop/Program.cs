using Dictionary.Dal.Access;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            ReadTranslateinUkr("table");
        }
        public static void ReadTranslateinUkr(string engword)
        {
            using var wordDB = new DictionaryDbContext();
            var uwords = wordDB.Set<Word>()
                .Include(t => t.EnglishWord)
                .Include(t => t.UkranianWord);

            var res = from uword in uwords
                      where uword.EnglishWord.Word == engword
                      select uword.UkranianWord;

            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine($" translete word:{engword}");
            foreach (var item in res)
            {
                Console.WriteLine($"finded:{item.Word}");
            }
        }

        public static void CreateDB()
        {
            using var wordDB=new DictionaryDbContext();
            wordDB.Database.EnsureDeleted();
            wordDB.Database.EnsureCreated();
        }

        public static void SeedDataEnglish(string engword, string[] ukrwords)
        {
            using var WordDB = new DictionaryDbContext();

            var eword = new EnglishWord() { Word = engword };
            var uwords = new UkranianWord[ukrwords.Length];

            for (int i = 0; i < ukrwords.Length; i++)
            {
                uwords[i] = new UkranianWord(){ Word= ukrwords[i] };

                Word words = new Word()
                {
                    UkranianWord = uwords[i],
                    EnglishWord = eword,

                };

                WordDB.Englishes.AddRange(eword);
                WordDB.Ukranians.AddRange(uwords[i]);
                WordDB.Words.AddRange(words);
            }

            WordDB.SaveChanges();
            Console.WriteLine("Data in database Changed");

        }
    }
}
