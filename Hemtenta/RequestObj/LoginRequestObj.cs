using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.RequestObj
{
    public class LoginRequestObj
    {
        [MinLength(3), MaxLength(15), Required]
        public string UserName { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }
    }
}
