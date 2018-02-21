namespace LibraryManagerApi.Models.Commands
{
    public class AddBookCommand
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Money Price { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string Publisher { get; set; }
        public Author Author { get; set; }
    }
}