using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual ICollection<Post> Posts { get; set; } = [];
        public virtual ICollection<Comment> Comments { get; set; } = [];

        public virtual ICollection<Likes> Likes { get; set; } = [];

        public virtual ICollection<GroupMessage> Messages { get; set; } = [];

        public virtual ICollection<GroupUser> Groups { get; set; } = [];

        public virtual ICollection<Follows> Follows { get; set; } = [];

        public virtual ICollection<Follows> Followers { get; set; } = [];

        // variabila in care vom retine rolurile existente in baza de date
        // pentru popularea unui dropdown list
        // in ideea ca admin poate modifica rolul unui user
        // admin poate sterge un user si atunci il sterge si din toate rolurile
        [NotMapped]
        public IEnumerable<SelectListItem>? AllRoles { get; set; }
    }
}
