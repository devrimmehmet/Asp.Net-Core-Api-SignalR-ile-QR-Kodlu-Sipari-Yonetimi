namespace DtoLayer.ProductDto
{
    public class GetProductDto
    {
        public int Product_ID { get; set; }
        public string? Product_Name { get; set; }
        public string? Product_Description { get; set; }
        public decimal Product_Price { get; set; }
        public string? Product_Image_Url { get; set; }
        public bool Product_Status { get; set; }
    }
}
