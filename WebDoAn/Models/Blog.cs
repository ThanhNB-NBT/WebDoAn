using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;


namespace WebDoAn.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string? Title { get; set; }
        public string? Alias { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string? Tags {  get; set; }
        public int? CategoryId {  get; set; }
        //public virtual Account? Account { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<BlogComment> TbBlogComments { get; set; } = new List<BlogComment>();
    }
}
