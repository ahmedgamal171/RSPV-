using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email address")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Choose an Option")]

        public bool? WillAttend {  get; set; }
    }
}
