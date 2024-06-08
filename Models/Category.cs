using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();

    }
}
