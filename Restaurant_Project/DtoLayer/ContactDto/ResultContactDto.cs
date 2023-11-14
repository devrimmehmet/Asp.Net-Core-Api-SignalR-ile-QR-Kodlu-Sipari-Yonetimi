using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ContactDto
{
    public class ResultContactDto
    {
        public int Contact_ID { get; set; }
        public string? Contact_Location { get; set; }
        public string? Contact_Phone { get; set; }
        public string? Contact_Mail { get; set; }
    }
}
