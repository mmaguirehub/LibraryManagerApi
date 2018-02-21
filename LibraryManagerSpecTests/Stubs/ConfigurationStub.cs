using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace LibraryManagerSpecTests.Stubs
{
    public class ConfigurationStub : IConfiguration
    {
        public IConfigurationSection LibraryDatabaseConnectionString { get; set; }

        private static IConfigurationRoot Configuration { get; set; }

        private readonly Dictionary<string, string> _configurationSections = new Dictionary<string, string>()
        {
            { "LibraryDatabaseConnectionString", "Server=tcp:libraryplatform.database.windows.net,1433;Initial Catalog=Library;Persist Security Info=False;User ID=mmlibrary;Password=hlBE5!@JXJ#l;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" }
        };

        public ConfigurationStub()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddInMemoryCollection(_configurationSections);
            Configuration = configurationBuilder.Build();
        }

        public IConfigurationSection GetSection(string key)
        {
            var section = Configuration.GetSection(key);

            LibraryDatabaseConnectionString = section;
            return Configuration.GetSection(key);
        } 

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            return Configuration.GetChildren();
        }

        public IChangeToken GetReloadToken()
        {
            return Configuration.GetReloadToken();
        }

        public string this[string key]
        {
            get { return GetSection(key).Value; }
            set { GetSection(key).Value = value; }
        }
    }
}