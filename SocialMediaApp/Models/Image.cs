using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public int? PostId {  get; set; }
        public string ImageUrl { get; set; }

        // Proprietati de navigatie: 1

        public virtual Post? Post { get; set; }

    }
}
