using System.Collections.Generic;
using LibraryManagerApi.Models;

namespace LibraryManagerApi.Repositories
{
    public interface ILibraryRepository
    {
        IEnumerable<Book> Books();
    }
}