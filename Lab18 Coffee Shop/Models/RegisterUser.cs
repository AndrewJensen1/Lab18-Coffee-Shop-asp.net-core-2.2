using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_Coffee_Shop.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Please make sure to enter a name")]
        [StringLength(40, ErrorMessage = "Name must be at least 1 character long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please make sure to enter a name")]
        [StringLength(40, ErrorMessage = "Name must be at least 1 character long")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b$", ErrorMessage ="Email must be in a conventional format i.e. sample@ie.com")]
        public string Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [RegularExpression(@"^([A-Za-z0-9]){4,20}$", ErrorMessage ="UserName must be at least 4 characters and no longer than 20 and only contain letters and numbers.")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage ="Password Must contain 1 capital Letter, 1 number and at least 8 characters.")]
        public string Password { get; set; }
    }
}
