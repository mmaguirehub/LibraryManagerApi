namespace LibraryManagerApi.Models
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public Money Price { get; }
        public string Genre { get; }
        public string SubGenre { get; }
        public string Publisher { get; }
        public Author Author { get; }
    }
}