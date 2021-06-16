using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Patient : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required, StringLength(40)]
        public string Insurance { get; set; }
        [Required]
        public DateTime DateAdmitted { get; set; }
        [Required]
        public DateTime DateCheckedOut { get; set; }
        public int Doctor_Id { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
