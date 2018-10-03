using Hemtenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Data
{
    public class SeedData
    {
        public static UserIntrest[] review =
        {
            new UserIntrest
            {
                Id = 1,
                Email = "ludde.pantzar@outlook.com",
                Data = "Bästa evenemanget jag vart på.",
                Score = 10
            }
        };

        public static Event[] events =
        {
            new Event
            {
                Id = 1,
                ImgUrl = "//placehold.it/300?text=Event 1",
                Title = "Event 1",
                Location = "Motala",
                Description = "Ett event",
                Date = new DateTime(2018, 7, 6)
            },
            new Event
            {
                Id = 2,
                ImgUrl = "//placehold.it/300?text=Event 2",
                Title = "Event 2",
                Location = "Linköping",
                Description = "Ett annat event",
                Date = new DateTime(2018,11,10)
            },
            new Event
            {
                Id = 3,
                ImgUrl = "//placehold.it/300?text=Event 3",
                Title = "Event 3",
                Location = "Linköping",
                Description = "Ännu ett event",
                Date = new DateTime(2018,10,09)
            },
            new Event
            {
                Id = 4,
                ImgUrl = "//placehold.it/300?text=Event 4",
                Title = "Event 4",
                Location = "Jönköping",
                Description = "Det bästa eventet",
                Date = new DateTime(2019,01,15)
            }
        };
    }
}
