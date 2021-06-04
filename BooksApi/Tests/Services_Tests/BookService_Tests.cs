using BooksApi.Models;
using BooksApi.Services;
using System;
using Xunit;

namespace BooksApi.Tests.Services_Tests
{
    public class BookService_Tests
    {
        private const string CollectionName = "Books";
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "BookstoreDb";
        private readonly BookService service;

        public BookService_Tests()
        {
            service = new BookService(new BookstoreDatabaseSettings
            {
                BooksCollectionName = CollectionName,
                ConnectionString = ConnectionString,
                DatabaseName = DatabaseName
            });
        }

        [Fact]
        public void TestGet()
        {
            // Arrange
            const int expectedNumber = 4;

            //Act
            var books = service.Get();

            //Assert
            Assert.Equal(expectedNumber, books.Count);
        }

        [Fact]
        public void TestGetById()
        {
            // Arrange
            Book expectedBook = new Book
            {
                Id = "60ba1572efb7bc2c133bd44b",
                BookName = "Clean Code",
                Price = 43.15M,
                Category = "Computers",
                Author = "Robert C. Martin"
            };

            // Act
            var bookFromDb = service.Get(expectedBook.Id);

            // Assert
            Assert.Equal(expectedBook.Id, bookFromDb.Id);
            Assert.Equal(expectedBook.BookName, bookFromDb.BookName);
            Assert.Equal(expectedBook.Price, bookFromDb.Price);
            Assert.Equal(expectedBook.Category, bookFromDb.Category);
            Assert.Equal(expectedBook.Author, bookFromDb.Author);
        }

        [Fact]
        public void TestCreate()
        {
            // Arrange
            Book book = new Book
            {
                BookName = "TestCreate",
                Price = 100,
                Category = "TestCreate",
                Author = "TestCreate"
            };
            var expectedName = book.BookName;
            var expectedPrice = book.Price;
            var expectedCategory = book.Category;
            var expectedAuthor = book.Author;

            //Act
            service.Create(book);
            var bookFromDb = service.Get(book.Id);

            //Assert
            Assert.Equal(expectedName, bookFromDb.BookName);
            Assert.Equal(expectedPrice, bookFromDb.Price);
            Assert.Equal(expectedCategory, bookFromDb.Category);
            Assert.Equal(expectedAuthor, bookFromDb.Author);
            service.Remove(book);
        }

        [Fact]
        public void TestUpdate()
        {
            //Arrange
            string newName = "TestUpdate";
            decimal newPrice = 100;
            string newCategory = "TestUpdate";
            string newAuthor = "TestUpdate";

            Book book = new Book()
            {
                Id = "60ba1572efb7bc2c133bd44a",
                BookName = newName,
                Price = newPrice,
                Category = newCategory,
                Author = newAuthor
            };

            //Act
            service.Update(book.Id, book);
            var bookFromDb = service.Get(book.Id);

            //Assert
            Assert.Equal(newName, bookFromDb.BookName);
            Assert.Equal(newPrice, bookFromDb.Price);
            Assert.Equal(newCategory, bookFromDb.Category);
            Assert.Equal(newAuthor, bookFromDb.Author);
        }

        [Fact]
        public void TestRemoveByObject()
        {
            //Arrange
            Book book = new Book
            {
                BookName = "TestRemoveByObject",
                Price = 10,
                Category = "TestRemoveByObject",
                Author = "TestRemoveByObject"
            };

            //Act
            service.Create(book);
            service.Remove(book);
            var bookFromDb = service.Get(book.Id);

            //Assert
            Assert.Null(bookFromDb);
        }

        [Fact]
        public void TestRemoveById()
        {
            //Arrange
            Book book = new Book
            {
                BookName = "TestRemoveById",
                Price = 100,
                Category = "TestRemoveById",
                Author = "TestRemoveById"
            };

            //Act
            service.Create(book);
            service.Remove(book.Id);
            var bookFromDb = service.Get(book.Id);

            //Assert
            Assert.Null(bookFromDb);
        }
    }
}
