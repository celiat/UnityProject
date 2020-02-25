using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unity.Models
{
    public class Role
    {
        public int ID { get; set; }
        public virtual Contributor Contributor { get; set; }
        public string RoleFunction { get; set; }
    }   
}
