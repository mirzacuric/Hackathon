using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Database.Entities
{
    public class Disability
    {
        public int DisabilityId { get; set; }
        public string DisabilityName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }

        //List of features
        public ICollection<Feature> Features { get; set; }
    }
}
