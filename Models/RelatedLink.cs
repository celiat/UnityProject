using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class RelatedLink
    {
        public int ID { get; set; }
        public string UrlString { get; set; }
        public string Relation { get; set; }
        public string Description { get; set; }
    }
}
