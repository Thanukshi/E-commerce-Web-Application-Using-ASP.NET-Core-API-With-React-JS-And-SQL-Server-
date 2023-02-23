namespace EMedicineBackend.Models
{
    public class ResponseClass
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<UsersClass> listUsers { get; set; }

        public UsersClass users { get; set; }

        public List<MedicineClass> listMedicine { get; set; }

        public MedicineClass medicine { get; set; }

        public List<CartClass> listCarts { get; set; }

        public List<OrderClass> listOrders { get; set; }

        public OrderClass order { get; set; }

        public List<OrderItemClass> listOrderItems { get; set; }

        public OrderItemClass orderItem { get; set; }

    }
}
