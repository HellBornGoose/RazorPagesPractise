using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPractise.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorSurname { get; set; }

        [NotMapped]
        public string FullName => $"{AuthorFirstName} {AuthorLastName} {AuthorSurname}";
        public string Style { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
