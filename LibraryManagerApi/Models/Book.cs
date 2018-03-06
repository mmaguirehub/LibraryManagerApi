using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using LibraryManagerApi.Models.Commands;

namespace LibraryManagerApi.Models
{
    public class Book
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string Publisher { get; set; }
        public Author Author { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otherBook = (Book)obj;

            return Id == otherBook.Id &&
                   string.Equals(Title, otherBook.Title) &&
                   Price == otherBook.Price &&
                   string.Equals(Genre, otherBook.Genre) &&
                   string.Equals(SubGenre, otherBook.SubGenre) &&
                   string.Equals(Publisher, otherBook.Publisher) &&
                   Equals(Author, otherBook.Author);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (Title?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ Price.GetHashCode();
                hashCode = (hashCode * 397) ^ (Genre?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (SubGenre?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Publisher?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Author?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}