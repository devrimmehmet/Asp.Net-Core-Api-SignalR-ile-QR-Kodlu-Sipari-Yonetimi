using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Contact
    {
        [Key]
        public int Contact_ID { get; set; }
        public string? Contact_Location { get; set; }
        public string? Contact_Phone { get; set; }
        public string? Contact_Mail { get; set; }
    }
}
