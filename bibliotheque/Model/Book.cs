using SQLite;
using PrimaryKeyAttribute = SQLite.PrimaryKeyAttribute;

namespace bibliotheque.Model
{
    public class Book
    {
        [PrimaryKey,AutoIncrement]
        public int BookId { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public string? Description { get; set; }

        public string? Language { get; set; }

        public string? Type { get; set; }

        public string? PublishingHouse { get; set; }



        public string? CoverPath { get; set; } = "default1.png";
    }
}
