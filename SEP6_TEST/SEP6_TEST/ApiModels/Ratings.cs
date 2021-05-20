using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP6_TEST.ApiModels
{
    public class Ratings
    {
        public List<OtheRanks> otherRanks { get; set; } = new List<OtheRanks>();
        //public OtheRanks[] otheRanks { get; set; } = new OtheRanks[5];
        public double rating { get; set; } = 0.0;
        public int ratingCount { get; set; } = 0;
    }
}
