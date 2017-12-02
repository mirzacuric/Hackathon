using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Database.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }

        //List of schools
        public ICollection<FeatureSchool> FeaturesSchools { get; set; }
    }
}
