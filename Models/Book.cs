using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesbooks.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
            [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Author { get; set; } = string.Empty;

        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Sells { get; set; }
    }
}