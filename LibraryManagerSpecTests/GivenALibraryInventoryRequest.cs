using LibraryManagerApi.Controllers;
using LibraryManagerSpecTests.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerSpecTests
{
    [TestClass]
    public class GivenALibraryInventoryRequest
    {
        [TestClass]
        public class ReturnAListOf
        {
            private LibraryRepositoryStub _libraryRespositoryStub;

            [TestMethod]
            public void AllTheBooks()
            {
                var configuration = new ConfigurationStub();
                var allBooks = new BooksController(configuration).GetBooks();
                Assert.AreEqual(allBooks, _libraryRespositoryStub.Books());
            }
        }

        [TestClass]
        public class ReturnABookAuthoredBy
        {
            [TestMethod]
            public void JKRowling()
            {
            }
        }

    }
}
