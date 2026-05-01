namespace SomaShareApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public int TextbookId { get; set; }

        public Textbook? Textbook { get; set; }

        public string? BuyerId { get; set; }

        public string? SellerId { get; set; }

        public decimal FinalPrice { get; set; }

        public string PaymentMethod { get; set; } = "Cash on Meetup";
    }
}