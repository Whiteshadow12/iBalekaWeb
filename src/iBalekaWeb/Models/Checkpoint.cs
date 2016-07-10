﻿using System;
using System.Collections.Generic;

namespace iBalekaWeb.Models
{
    public partial class Checkpoint
    {
        public int CheckpointId { get; set; }
        public bool Deleted { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RouteId { get; set; }

        public virtual Route Route { get; set; }
    }
}
