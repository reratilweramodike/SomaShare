using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public int TextbookId { get; set; }

        public Textbook? Textbook { get; set; }

        public string BuyerId { get; set; } = string.Empty;

        public ApplicationUser? Buyer { get; set; }

        [Range(1, 10000, ErrorMessage = "Offer must be between R1 and R10 000")]
        public decimal OfferPrice { get; set; }

        [StringLength(300)]
        public string Message { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}