using LibraryManagerApi.ConfigurationModels;
using Microsoft.Extensions.Configuration;

namespace LibraryManagerApi.Repositories
{
    public class LibraryRepository
    {
        private LibraryDatabaseConnectionString connectionString;

        public LibraryRepository(IConfiguration configuration)
        {
            connectionString = LibraryDatabaseConnectionString.FromConfiguration(configuration);
        }
    }
}
