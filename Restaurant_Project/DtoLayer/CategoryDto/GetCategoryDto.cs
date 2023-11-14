using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.CategoryDto
{
    public class GetCategoryDto
    {
        public int Category_ID { get; set; }
        public string? Category_Name { get; set; }
        public bool Category_Status { get; set; }
    }
}
