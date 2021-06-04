using BooksApi.Services;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest
    {
        private readonly BookService _bookService;
        public UnitTest(BookService bookService)
        {
            _bookService = bookService;
        }

        [Fact]
        public void TestGet()
        {

        }

        [Fact]
        public void TestGetById()
        {
            // Arrange
            const string expected = "1";
            const string id = "1";

            // Act
            var book = _bookService.Get(id);

            // Assert
            Assert.Equal(expected, book.Id);
        }

        [Fact]
        public void TestCreate()
        {

        }

        [Fact]
        public void TestUpdate()
        {

        }

        [Fact]
        public void TestRemoveByObject()
        {

        }

        [Fact]
        public void TestRemoveById()
        {

        }
    }
}
