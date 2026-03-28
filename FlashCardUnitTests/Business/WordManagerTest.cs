using Moq;
using Xunit;
using Flashcard.Business.Concrete;
using Flashcard.DataAccess.Abstract;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Flashcard.Entities.Concrete;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq.Expressions;


namespace FlashCardUnitTests.Business

{
    public class WordManagerTests
    {

        private readonly WordManager _wordManager;

        private readonly Mock<IWordDal> _mockWordDal;

        public WordManagerTests()
        {
            _mockWordDal = new Mock<IWordDal>(); //IwordDal kopyası

            _wordManager = new WordManager(_mockWordDal.Object);//.Object gerçek bir nesne parametre veriliyor gibi anlaşılmasını sağlar


        }


        [Fact]
        public void Add_WhenWordAlreadyExists_ReturnsErrorResult()
        {

            //arange
            var wordToSafe = new Word{ Id = 10 , OriginalText = "disponsibile" };

            _mockWordDal.Setup(x => x.Get(It.IsAny<Expression<Func<Word, bool>>>())).Returns(wordToSafe);

            var result = _wordManager.Add(wordToSafe);

            Assert.False(result.Success);

            Assert.Equal("kelime zaten var", result.Message);
 
        }


    }

  

}