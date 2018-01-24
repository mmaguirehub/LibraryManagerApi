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
            { "LibraryDatabaseConnectionString", "This_Is_A_Test_Configuration_ConnectionString" }
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