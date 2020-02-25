using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Contributor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        [Key]
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
