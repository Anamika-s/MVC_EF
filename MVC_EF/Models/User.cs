namespace MVC_EF.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Password { get; set; }
        public string ReTypePassword { get; set; }
        public Decimal Salary { get; set; }
    }
}
