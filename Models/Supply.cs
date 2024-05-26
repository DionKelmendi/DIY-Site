using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models
{
    public class Supply
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}