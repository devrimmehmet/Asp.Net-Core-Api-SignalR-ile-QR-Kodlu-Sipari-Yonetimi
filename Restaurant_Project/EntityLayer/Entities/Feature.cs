using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Feature
    {
        [Key]
        public int Feature_ID { get; set; }
        public string? Feature_Title_1 { get; set; }
        public string? Feature_Description_1 { get; set; }
        public string? Feature_Image_Url_1 { get; set; }
        public string? Feature_Title_2 { get; set; }
        public string? Feature_Description_2 { get; set; }
        public string? Feature_Image_Url_2 { get; set; }
        public string? Feature_Title_3 { get; set; }
        public string? Feature_Description_3 { get; set; }
        public string? Feature_Image_Url_3 { get; set; }
    }
}
