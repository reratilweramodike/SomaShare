using System.ComponentModel.DataAnnotations;

namespace SomaShareApp.Models
{
    public class WantedAd
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Campus { get; set; }

        public string? UserId { get; set; } // who posted it

        public ApplicationUser? User { get; set; } // navigation
    }
}