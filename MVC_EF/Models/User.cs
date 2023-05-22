using System.ComponentModel.DataAnnotations;

namespace MVC_EF.Models
{
    public class User
    {
        
        public int UserId { get; set; }
        [Required(ErrorMessage ="Name is must")]
        [StringLength(20, ErrorMessage ="Max 20 char")]
        [MinLength(5, ErrorMessage ="Min 5 ")]
        [RegularExpression("[a-z A-Z]+")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Address is must")]
        public string Address { get; set; }

        public DateTime Dob { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="PAssword is must")]
         
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [ScaffoldColumn(false)]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ReTypePassword { get; set; }

        //[Range(100000, 300000, ErrorMessage =)]
        public Decimal Salary { get; set; }
    }
}
