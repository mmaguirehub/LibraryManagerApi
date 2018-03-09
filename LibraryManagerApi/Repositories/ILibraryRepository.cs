using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagerApi.Models;

namespace LibraryManagerApi.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Book>> BooksAsync();
    }
}