namespace SocialMediaApp.Models
{
    public class Follows
    {
        public string? FollowerId { get; set; }
        public string? FollowedId { get; set; }

        public bool Accepted { get; set; }

        // Proprietati de navigatie: 2

        public virtual ApplicationUser? Follower { get; set; }
        public virtual ApplicationUser? Followed { get; set; }
    }
}
