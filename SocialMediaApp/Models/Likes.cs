using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaApp.Models
{
    public class Likes
    {
        public string? UserId { get; set; }

        public int? PostId { get; set; }

        public DateTime LikeDate { get; set; }

        // Proprietati de navigatie: 2

        public virtual ApplicationUser? User { get; set; }

        public virtual Post? Post { get; set; }
    }
}
