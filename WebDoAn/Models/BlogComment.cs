using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;


namespace WebDoAn.Models
{
    [Table("BlogComment")]
    public class BlogComment
    {
        [Key]
        public int CommentID { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public int BlogID { get; set; }
    }
}
