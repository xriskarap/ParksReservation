﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Campsite
    {
        public int SiteID { get; set; }

        public int CampgroundID { get; set; }

        public int SiteNumber { get; set; }

        public int MaxOccupancy { get; set; }

        public bool Accessible { get; set; }

        public int MaxRVLength { get; set; }

        public bool UtilityAccess { get; set; }
    }
}
