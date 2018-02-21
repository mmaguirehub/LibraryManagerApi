using System.Runtime.Serialization;
using System.Security.Permissions;
using LibraryManagerApi.Models.Commands;

namespace LibraryManagerApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}