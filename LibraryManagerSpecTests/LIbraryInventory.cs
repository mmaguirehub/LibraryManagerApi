using LibraryManagerApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerSpecTests
{
    [TestClass]
    public class LIbraryInventory
    {
        [TestMethod]
        public void Connection_string_retrieved()
        {
            var configuration = new ConfigurationStub();
            var booksController = new BooksController(configuration);

            Assert.AreEqual("This_Is_A_Test_Configuration_ConnectionString", configuration.LibraryDatabaseConnectionString.Value);
        }
    }
}
