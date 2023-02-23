namespace EMedicineBackend.Models
{
    public class OrderItemClass
    {
        public int orderItemID { get; set; }
        public int OrderID { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}