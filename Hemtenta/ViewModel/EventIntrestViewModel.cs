using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hemtenta.Models;

namespace Hemtenta.ViewModel
{
    public class EventIntrestViewModel
    {
        public List<UserIntrest> userintrests { get; set; }

        public EventIntrestViewModel(List<UserIntrest> userintrests)
        {
            var sorted = (from user in userintrests
                            orderby user.Owner descending, !user.Owner
                            select user).ToList();

            this.userintrests = userintrests;
        }
    }
}
