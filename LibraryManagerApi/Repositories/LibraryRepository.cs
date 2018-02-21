using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        // make this async
        public IEnumerable<Book> Books()
        {
            using (var db = DbConnection())
            {
                return db.Query<Book>("SELECT * FROM dbo.Books");
            }
        }

        private IDbConnection DbConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
