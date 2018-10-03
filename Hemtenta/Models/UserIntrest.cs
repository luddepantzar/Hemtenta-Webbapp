using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Models
{
    public class UserIntrest
    {
        public int Id { get; set; }

        [MaxLength(250), Required]
        public string Data { get; set; }
    }
}
