using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models
{
    public class UserFavorites
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
