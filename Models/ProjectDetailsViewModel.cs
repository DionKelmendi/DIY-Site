using System.ComponentModel.DataAnnotations;

namespace DIY_Site.Models { 
public class ProjectDetailsViewModel
{
    public Project Project { get; set; }
    public List<Supply> Supplies { get; set; }
}
}