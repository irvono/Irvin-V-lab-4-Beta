﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.Models
{
       public class Event
        {
            public int EventID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime EventDateTime { get; set; }
            public int UserID { get; set; }

            // An event belongs to one User
            public virtual User User { get; set; }
        }
}
