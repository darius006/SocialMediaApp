using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Numele este obligatoriu")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Setarea vizibilității este obligatorie")]
        [RegularExpression(@"^(public|privat)$",
            ErrorMessage = "Profilul poate fi \"public\" sau \"privat\"")]
        public string ProfileVisibility { get; set; }

        [Required(ErrorMessage = "Descrierea profilului este obligatorie")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Poza de profil este obligatorie")]
        public string ProfilePicture { get; set; }


        // Proprietati de navigatie: 7
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<Likes> Likes { get; set; } = new List<Likes>();

        public virtual ICollection<GroupMessage> Messages { get; set; } = new List<GroupMessage>();

        public virtual ICollection<GroupUser> Groups { get; set; } = new List<GroupUser>();

        public virtual ICollection<Follows> Follows { get; set; } = new List<Follows>();

        public virtual ICollection<Follows> Followers { get; set; } = new List<Follows>();

    }
}
