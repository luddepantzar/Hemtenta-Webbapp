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
<<<<<<< HEAD:Hemtenta/Models/Review.cs

        [Range(1, 10), Required]
        public int Score { get; set; }
=======
>>>>>>> 44da56e979e857a0b3d209a80a788a6e67a4076c:Hemtenta/Models/UserIntrest.cs
    }
}
