namespace EMedicineBackend.Models
{
    public class OrderClass
    {
        public int orderID { get; set; }
        public int UserID { get; set; }
        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    }
}