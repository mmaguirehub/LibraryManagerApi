namespace LibraryManagerApi.Models
{
    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public Money Price { get; private set; }
        public string Genre { get; private set; }
        public string SubGenre { get; private set; }
        public string Publisher { get; private set; }
        public Author Author { get; private set; }

        public Book FromBuilder(BookBuilder builder)
        {
            //https://stackoverflow.com/questions/1304154/immutable-objects-with-object-initialisers
        }
    }

    public class BookBuilder
    {

    }
}