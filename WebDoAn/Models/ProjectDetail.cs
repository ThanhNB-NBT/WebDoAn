using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;


namespace WebDoAn.Models
{
    [Table("ProjectDetail")]
    public class ProjectDetail
    {
        [Key]
        public int ProjectDetailId { get; set; }
        public string? ProjectName { get; set; }
        public string? Title { get; set; }
        public string? Alias { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public string? Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string? Client {  get; set; }
        public string? Link {  get; set; }
    }
}
