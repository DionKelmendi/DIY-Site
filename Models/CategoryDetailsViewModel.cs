using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models
{
    public class CategoryDetailsViewModel
    {
        public Category Category { get; set; }
        public List<Project> Projects { get; set; }
    }
}