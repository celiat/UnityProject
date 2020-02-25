using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unity.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public DateTime? LastModifiedTime { get; set; }
        public string LastModifiedUser { get; set; }
    }
}