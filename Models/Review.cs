using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string? ReviewerId { get; set; }

        public string? ReviewedUserId { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string? Comment { get; set; }
    }
}
