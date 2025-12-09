using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class GroupMessage
    {
        [Key]
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string UserId { get; set; }

        public string TextContent { get; set; }


        // Proprietati de navigatie: 2

        public virtual Group? Group { get; set; }
        
        public virtual ApplicationUser? User { get; set; }
    }
}
