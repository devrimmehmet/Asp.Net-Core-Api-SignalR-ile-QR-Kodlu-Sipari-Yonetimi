using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }
        public string? Product_Name { get; set; }
        public string? Product_Description { get; set; }
        public decimal Product_Price { get; set; }
        public string? Product_Image_Url { get; set; }
        public bool Product_Status { get; set; }
        [ForeignKey("Category_ID")] // Burada "Category" string'i, Category sınıfındaki navigation property ismini ifade etmelidir.
        public Category? Category { get; set; }
    }
}
