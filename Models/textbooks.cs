using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class Textbook
    {
        [Key]
        public int Book_ID { get; set; }

        [Required(ErrorMessage = "Book name is required")]
        public string? Book_Name { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Publisher is required")]
        public string? Publisher_Name { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string? Subject { get; set; }

      
        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10000")]
        public decimal Price { get; set; }

      
        public string? Condition { get; set; }
        public string? Campus { get; set; }

     
        [Url(ErrorMessage = "Enter a valid URL")]
        public string? ImageUrl { get; set; }
    }
}