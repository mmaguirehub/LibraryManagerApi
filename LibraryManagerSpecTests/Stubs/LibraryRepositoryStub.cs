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
                    Price = 17.70m,
                    Genre = "nonfiction",
                    SubGenre = "trivia",
                    Publisher = "BBC",
                    Author = new Author()
                    {
                        Id = 111,
                        FirstName = "David",
                        Surname = "Bradsky"
                    }
                }
            };
        }
    }
}