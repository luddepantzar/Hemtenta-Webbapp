using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Models
{
    public class Event
    {
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string Title { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime Date { get; set; }

        [Required]
        public string Location { get; set; }

        [MaxLength(250), Required]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl), Required]
        public string ImgUrl { get; set; }

        public int ReadCount { get; set; }

        public virtual List<UserIntrest> UserIntrests { get; set; }
    }
}
