using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace LibraryManagerApi.ConfigurationModels
{
    public class LibraryDatabaseConnectionString
    {
        public string Value { get; set; }

        public LibraryDatabaseConnectionString()
        {
        }

        private LibraryDatabaseConnectionString(IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("LibraryDatabaseConnectionString");
            Value = connectionString.Value;
        }

        public static LibraryDatabaseConnectionString FromConfiguration(IConfiguration configuration)
        {
            return new LibraryDatabaseConnectionString(configuration);
        }

        public static implicit operator string(LibraryDatabaseConnectionString libraryDatabaseConnectionString)
        {
            return libraryDatabaseConnectionString.Value;
        }
    }
}
