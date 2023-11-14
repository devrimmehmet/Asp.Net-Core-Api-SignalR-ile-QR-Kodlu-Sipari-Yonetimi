using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        public int Testimonial_ID { get; set; }
        public string? Testimonial_Name { get; set; }
        public string? Testimonial_Title { get; set; }
        public string? Testimonial_Comment { get; set; }
        public string? Testimonial_Image_Url { get; set; }
        public bool Testimonial_Status { get; set; }
    }
}
