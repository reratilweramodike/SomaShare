using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public int TextbookId { get; set; }

        public Textbook? Textbook { get; set; }

        public string? BuyerId { get; set; }

        public ApplicationUser? Buyer { get; set; }

        [Required]
        public decimal OfferPrice { get; set; }

        public string Status { get; set; } = "Pending";
    }
}