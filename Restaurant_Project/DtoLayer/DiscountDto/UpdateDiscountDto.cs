namespace DtoLayer.DiscountDto
{
    public class UpdateDiscountDto
    {
        public int Discount_ID { get; set; }
        public string? Discount_Title { get; set; }
        public string? Discount_Amount { get; set; }
        public string? Discount_Description { get; set; }
        public string? Discount_Image_Url { get; set; }
    }
}
