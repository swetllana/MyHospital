﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Doctor : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialization { get; set; }
        public virtual ICollection<Patient> Patients  { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
