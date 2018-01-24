using System.Collections.Generic;
using LibraryManagerApi.Models;
using LibraryManagerApi.Repositories;

namespace LibraryManagerSpecTests
{
    public class LibraryRepositoryStub : ILibraryRepository
    {
        public IEnumerable<Book> Books()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "One",
                    Price = new Money(17.70),
                    Genre = "nonfiction",
                    SubGenre = "trivia",
                    Publisher = "BBC",
                    Author = new Author()
                    {
                        FirstName = "David",
                        Surname = "Bradsky"
                    }
                }
            };
        }
    }
}