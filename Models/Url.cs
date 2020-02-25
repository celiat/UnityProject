using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Url
    {
        public int ID { get; set; }
        public string UrlString { get; set; }
        public string ForwardUrl { get; set; }
        public int? OutletID { get; set; }
        public string Description { get; set; }
        public int TimelineID { get; set; }
        public virtual Timeline Timeline { get; set; }
    }
}
