using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please input User Name")]
        public string? Username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Please provide password")]
        public string? Password { get; set; }
    }
}
