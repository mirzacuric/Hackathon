using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Database.Entities
{
    public class FeatureSchool
    {
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
