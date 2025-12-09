using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? PostId { get; set; }

        public string? Content { get; set; }

        // Proprietati de navigatie: 2

        public ApplicationUser? User { get; set; }
        public Post? Post { get; set; }

    }
}
