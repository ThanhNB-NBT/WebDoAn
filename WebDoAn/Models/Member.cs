using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace WebDoAn.Models
{
    [Table("Member")]
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? WorkPosition { get; set; }
        public string? Detail { get; set; }
        public string? Link { get; set; }
        public string? Message { get; set; }
        public string? Image { get; set; }
    }
}
