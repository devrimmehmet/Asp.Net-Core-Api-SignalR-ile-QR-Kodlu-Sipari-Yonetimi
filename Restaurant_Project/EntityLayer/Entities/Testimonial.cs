using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Testimonial
    {
        [Key]
        public int Testimonial_ID { get; set; }
        public string? Testimonial_Name { get; set; }
        public string? Testimonial_Title { get; set; }
        public string? Testimonial_Comment { get; set; }
        public string? Testimonial_Image_Url { get; set; }
        public bool Testimonial_Status { get; set; }
    }
}
