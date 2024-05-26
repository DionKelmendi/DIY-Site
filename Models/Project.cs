using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ThumbnailURL { get; set; }
        public string? Description { get; set; }
        public string? VideoURL { get; set; }
        public List<Supply> Supplies { get; set; } = new List<Supply>();
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
