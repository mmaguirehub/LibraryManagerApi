using LibraryManagerApi.Controllers;
using LibraryManagerApi.Repositories;
using LibraryManagerSpecTests.Stubs;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerSpecTests
{
    [TestClass]
    public class GivenTheApiConfiguration
    {
        private readonly ConfigurationStub _configurationStub;

        public GivenTheApiConfiguration()
        {
            _configurationStub = new ConfigurationStub();
        }

        [TestMethod]
        public void CheckThatTheLibraryConnectionStringCanBeRetrieved()
        {
            var booksController = new BooksController(_configurationStub);

            Assert.AreEqual("This_Is_A_Test_Configuration_ConnectionString", _configurationStub.GetSection("LibraryDatabaseConnectionString").Value);
        }
    }
}
