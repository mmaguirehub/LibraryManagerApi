using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerTests
{
    [TestClass]
    public class LibraryInventorySpec
    {
        [TestMethod]
        public void Request_all_books_owned()
        {
            var books = new BooksController;
            Assert.AreEqual(books, _bookStore().books);
        }
    }
}
