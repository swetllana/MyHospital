using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Test : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime TestDate { get; set; }
        [Required]
        public DateTime TestTime { get; set; }
        [Required, StringLength(300)]
        public string Result { get; set; } 
        public int Patient_Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int Doctor_Id { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
