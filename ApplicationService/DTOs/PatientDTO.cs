using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class PatientDTO
    {
        public int Patient_Id { get; set; }  
        public string Name { get; set; }    
        public string Insurance { get; set; }  
        public DateTime DateAdmitted { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public int Doctor_Id { get; set; }
        public virtual DoctorDTO Doctor { get; set; }
    }
}
