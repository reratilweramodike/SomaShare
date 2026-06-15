using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class Textbook
    {
        [Key]
        public int Book_ID { get; set; }

        [Required(ErrorMessage = "Book name is required")]
        public string Book_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "ISBN is required")]
        public string Isbn { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course code is required")]
        public string CourseCode { get; set; } = string.Empty;

        [Range(1, 10000, ErrorMessage = "Price must be between R1 and R10 000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Condition is required")]
        public string Condition { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campus is required")]
        public string Campus { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string Status { get; set; } = "Available";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

  
        public string? SellerId { get; set; }

       
        public ApplicationUser? Seller { get; set; }
    }
}