using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        public string? Category_Name { get; set; }
        public bool Category_Status { get; set; }
    }
}
