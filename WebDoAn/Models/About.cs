using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace WebDoAn.Models
{
    [Table("About")]
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string? Title { get; set; }
        public bool IsActive { get; set; }
        public string? AboutUs { get; set; }      
        public string? OurStory { get; set; }
        public string? Image { get; set; }
    }
}
