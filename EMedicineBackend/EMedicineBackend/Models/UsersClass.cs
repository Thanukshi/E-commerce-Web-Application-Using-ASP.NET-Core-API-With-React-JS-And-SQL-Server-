namespace EMedicineBackend.Models
{
    public class UsersClass
    {
        public int userID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public decimal Fund { get; set; }
        public string UserType { get; set; }
        public int UserStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
