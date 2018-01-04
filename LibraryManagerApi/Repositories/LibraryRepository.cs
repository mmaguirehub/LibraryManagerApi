using LibraryManagerApi.ConfigurationModels;
using Microsoft.Extensions.Configuration;

namespace LibraryManagerApi.Repositories
{
    public class LibraryRepository
    {
        private LibraryDatabaseConnectionString _connectionString;

        public LibraryRepository(IConfiguration configuration)
        {
            _connectionString = LibraryDatabaseConnectionString.FromConfiguration(configuration);
        }

    }
}
