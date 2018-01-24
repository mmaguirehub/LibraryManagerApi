using System.Collections.Generic;
using LibraryManagerApi.Models;
using LibraryManagerApi.Repositories;

namespace LibraryManagerSpecTests
{
    public class LibraryRepositoryStub : ILibraryRepository
    {
        public IEnumerable<Book> Books()
        {
            throw new System.NotImplementedException();
        }
    }
}