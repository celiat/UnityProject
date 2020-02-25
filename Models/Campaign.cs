using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Campaign
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Url> Urls { get; set; }
        public virtual ICollection<Timeline> Timelines { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RelatedLink> RelatedLinks { get; set; }

    }
}
