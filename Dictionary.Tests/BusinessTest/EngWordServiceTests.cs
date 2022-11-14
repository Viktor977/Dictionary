using Dictionary.Bal.ModelsDto;
using Dictionary.Bal.Services;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Tests.BusinessTest
{
    public class EngWordServiceTests
    {
        [Test]
        public void EngWordServiseTest_AddWordAsync_ReturnCount()
        {
            ////Arrange
            //var engWord = new EnglishWordDto { Word = "Test" };
            //var mockUnitOfWork = new Mock<IUnitOfWork>();
            //mockUnitOfWork.Setup(x => x.EnglishWordRepository.Add(It.IsAny<EnglishWord>()));

          //  var service = new EngWordService(UnitTestHelper.CreateMapperProfile(),mockUnitOfWork.Object); ;

            //Act
         //  await service.Add(engWord);

            //Assert
            //mockUnitOfWork.Verify(t=>t.EnglishWordRepository.Add(It.Is<EnglishWord>(x=>
            //x.Word==engWord.Word)),Times.Once);
            //mockUnitOfWork.Verify(t => t.SaveAsync(),Times.Once);


        }
    }
}
