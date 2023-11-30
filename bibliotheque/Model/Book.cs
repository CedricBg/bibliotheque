using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public string? Description { get; set; }

        public string? Language { get; set; }

        public string? Type { get; set; }

        public List<string>? CoverPath { get; set; }
    }
}
