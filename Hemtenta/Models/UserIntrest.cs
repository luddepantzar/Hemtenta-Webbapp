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
        public string UserName { get; set; }

        public virtual int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
