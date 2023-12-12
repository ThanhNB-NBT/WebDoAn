using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;


namespace WebDoAn.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Client { get; set; }
        public string? Link { get; set; }
    }
}
