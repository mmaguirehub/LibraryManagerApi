using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using LibraryManagerApi.Models;
using Microsoft.Extensions.Configuration;

namespace LibraryManagerApi.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly LibraryDatabaseConnectionString _connectionString;

        public LibraryRepository(IConfiguration configuration)
        {
            _connectionString = LibraryDatabaseConnectionString.FromConfiguration(configuration);
        }

        public async Task<IEnumerable<Book>> BooksAsync()
        {
            using (var dbConnection = DbConnection())
            {
                var response = new Dictionary<int, Book>();
                return await dbConnection.QueryAsync<Book, Author, Book>(@"
                                SELECT book.*, author.* 
                                FROM dbo.Books AS book INNER JOIN dbo.Authors AS author ON book.AuthorId = author.Id",
                    (book, author) =>
                    {
                        book.Author = author;
                        return book;
                    });
            }
        }

        private IDbConnection DbConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}