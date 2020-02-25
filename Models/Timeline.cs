using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Timeline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OutletID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Event> Events { get; set; }       
    }
}
