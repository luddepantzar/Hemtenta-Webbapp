using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int ReadCount { get; set; }

        //public virtual Genre Genre { get; set; }
        public virtual List<UserIntrest> UserIntrests { get; set; }
    }
}
