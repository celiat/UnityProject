using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Promotion
    {
        public string ID { get; set; }
        public int? Tier { get; set; }
        public string SourceCode { get; set; }
        public int? ProductVariant { get; set; }
        public string ProductCatalog { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? AskArray { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
