using Hemtenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.ViewModel
{
    public class CreateEventReviewViewModel
    {
        public Event events { get; set; }
        public UserIntrest userintrests { get; set; }

        public CreateEventReviewViewModel(Event Events)
        {
            events = Events;
        }
    }
}
