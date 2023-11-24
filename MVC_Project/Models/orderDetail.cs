using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class orderDetail {
        [Key]
        public int order_detail_id { get; set; }
        public int order_id { get; set; }
        public int room_id { get; set; }
        public int num { get; set; }
    }
}