using System;
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otherAuthor = (Author)obj;

            return Id == otherAuthor.Id &&
                   string.Equals(FirstName, otherAuthor.FirstName) &&
                   string.Equals(Surname, otherAuthor.Surname);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (FirstName?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Surname?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}