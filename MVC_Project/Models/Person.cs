using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int Personid { get; set; }
        public string Fullname { get; set; }
    }
}