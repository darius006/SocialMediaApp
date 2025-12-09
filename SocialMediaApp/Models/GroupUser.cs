using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaApp.Models
{
    public class GroupUser
    {
        public string UserId { get; set; }
        public int GroupId { get; set; }

        public bool IsModerator { get; set; }


        // Proprietati de navigatie: 2
        public virtual Group? Group { get; set; }

        public virtual ApplicationUser? User { get; set; } 
    }
}
