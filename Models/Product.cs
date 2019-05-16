namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public int Rating { get; set; }
        public long BarCode { get; set; }
        public int Category { get; set; }
        public int Status { get; set; }
    }

}