namespace EMedicineBackend.Models
{
    public class CartClass
    {
        public int cartID { get; set; }
        public int UserID { get; set; }
        public int MedicineID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}