using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models {
    [Table("HeThongPP")]
    public class HeThongPP {
        [Key]
        public int MaHTPP { get; set; }
        public string TenHTPP {get; set;}
    }
}