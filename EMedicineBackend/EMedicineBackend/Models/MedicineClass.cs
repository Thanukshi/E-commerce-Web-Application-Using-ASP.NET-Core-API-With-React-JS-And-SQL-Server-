namespace EMedicineBackend.Models
{
    public class MedicineClass
    {
        public int medicineID { get; set; }
        public string MedicineName { get; set; }
        public string ManufactureName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ImageUrl { get; set; }
        public int MedisineStatus { get; set; }
    }
}