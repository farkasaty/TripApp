﻿using System;
using System.Collections.Generic;

namespace TripApp.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}
