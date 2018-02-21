namespace LibraryManagerApi.Models.Commands
{
    public class AddAuthorCommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}