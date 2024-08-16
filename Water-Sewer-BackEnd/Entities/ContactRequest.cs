using System.ComponentModel.DataAnnotations;

namespace Water_Sewer_BackEnd.Entities
{
    public class ContactRequest
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
    }
}
