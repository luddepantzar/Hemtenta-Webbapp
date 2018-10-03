using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.RequestObj
{
    public class RegisterRequestObj
    {
        [MinLength(3), MaxLength(15), Display(Name = "Användarnamn"), Required]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Det måste vara en giltig email"), DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }

        [DataType(DataType.Password), Display(Name = "Lösenord"), Required]
        public string Password { get; set; }

        [DataType(DataType.Password), Required, Display(Name = "Bekräfta lösenord"), Compare("Password")]
        public string ConfirmPassword { get; set; }

        [MinLength(10), MaxLength(200), Display(Name = "Deskription"), Required]
        public string Description { get; set; }
    }
}
