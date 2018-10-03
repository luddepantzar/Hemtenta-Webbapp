using Hemtenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.ViewModel
{
    public class CreateEventViewModel
    {
        public Event Events { get; set; }
        public UserIntrest Userintrests { get; set; }

        public CreateEventViewModel(Event events)
        {
            Events = events;
        }
    }
}
