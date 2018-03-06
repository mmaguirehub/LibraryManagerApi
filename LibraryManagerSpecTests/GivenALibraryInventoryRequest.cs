using System.Linq;
using LibraryManagerApi.Controllers;
using LibraryManagerApi.Repositories;
using LibraryManagerSpecTests.Stubs;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerSpecTests
{
    [TestClass]
    public class GivenALibraryInventoryRequest
    {
        [TestClass]
        public class ReturnAListOf
        {
            private readonly LibraryRepositoryStub _libraryRespositoryStub;
            private readonly ConfigurationStub _configurationStub;

            public ReturnAListOf()
            {
                _configurationStub = new ConfigurationStub();
                _libraryRespositoryStub = new LibraryRepositoryStub();
            }

            [TestMethod]
            public void GetAllTheBooks()
            {
                var allBooks = new BooksController(_configurationStub, _libraryRespositoryStub).GetBooks();
                Assert.IsTrue(allBooks.SequenceEqual(_libraryRespositoryStub.Books()));
            }
        }
    }
}
