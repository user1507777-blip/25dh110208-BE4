namespace 25dh110208.Models
{
    // Model mô tả một sản phẩm.
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
