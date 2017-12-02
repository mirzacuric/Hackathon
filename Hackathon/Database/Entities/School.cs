using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Database.Entities
{
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }

        public Location Location { get; set; }

        public ICollection<FeatureSchool> FeaturesSchools { get; set; }
    }
}
