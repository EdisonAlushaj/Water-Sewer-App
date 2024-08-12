using System.ComponentModel.DataAnnotations;

namespace Water_Sewer_BackEnd.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(10000)]
        public string Image { get; set; }
    }
}
