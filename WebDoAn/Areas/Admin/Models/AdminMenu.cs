using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDoAn.Areas.Admin.Models
{
    [Table("AdminMenu")]
    public class AdminMenu
    {
        [Key]
        public long MenuAdminId { get; set; }
        public string? ItemName { get; set; }
        public int ItemLevels { get; set; }
        public int ParentLevels { get; set; }
        public int ItemOrder { get; set; }
        public bool IsActive { get; set; }
        public string? AreaName { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? Icon {  get; set; }
    }
}
