using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DewJUnit2MVC.Models
{ // the customer class defines the customer model
    public class Customer
    {
        [Key]
        public int? CustID { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a username")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string? Password { get; set; }
    }
}
