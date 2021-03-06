using System;
using Xunit;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            
            //Act
            var newPublicationDate=DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            //Assert
            var expectedPublicationDate=newPublicationDate.ToShortDateString();
            var actualPublicationDate=book.PublishDate.ToShortDateString();

            Assert.Equal(expectedPublicationDate,actualPublicationDate);

        }
    }

    internal class Author
    {
        public Author()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Book
    {
        public Book()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public object Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Publisher { get; set; }

        internal void ChangePublicationDate(DateTime newPublicationDate)
        {
            throw new NotImplementedException();
        }
    }
}