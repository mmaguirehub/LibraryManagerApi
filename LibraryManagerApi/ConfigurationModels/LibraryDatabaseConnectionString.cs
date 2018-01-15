using Microsoft.Extensions.Configuration;

namespace LibraryManagerApi.ConfigurationModels
{
    public class LibraryDatabaseConnectionString
    {
        private string Value { get; }

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
