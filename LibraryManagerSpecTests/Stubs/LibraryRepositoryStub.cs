using System.Collections.Generic;
using LibraryManagerApi.Models;
using LibraryManagerApi.Models.Commands;
using LibraryManagerApi.Repositories;

namespace LibraryManagerSpecTests.Stubs
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