﻿namespace DtoLayer.TestimonialDto
{
    public class GetTestimonialDto
    {
        public int Testimonial_ID { get; set; }
        public string? Testimonial_Name { get; set; }
        public string? Testimonial_Title { get; set; }
        public string? Testimonial_Comment { get; set; }
        public string? Testimonial_Image_Url { get; set; }
        public bool Testimonial_Status { get; set; }
    }
}
