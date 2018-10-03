using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Models
{
    public class Review
    {
        public int Id { get; set; }

        [DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }

        [MaxLength(250), Required]
        public string Data { get; set; }

        [Range(1, 10), Required]
        public int Score { get; set; }
    }
}
