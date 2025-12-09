using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public int? PostId { get; set; }
        public string VideoUrl { get; set; }

        // Proprietati de navigatie: 1

        public virtual Post? Post { get; set; }
    }
}
