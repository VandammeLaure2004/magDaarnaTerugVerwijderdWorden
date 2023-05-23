using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivesBlog.Ui.Mvc.Models
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public int? AuthorId { get; set; }
        public Person? Author { get; set; }
    }
}
