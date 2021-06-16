using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class PatientVM
    {
        public int Patient_Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(40)]
        public string Insurance { get; set; }
        [Required]

        [Display(Name = "Date Admitted")]
        [DataType(DataType.Date)]
        public DateTime DateAdmitted { get; set; }
        [Required]

        [Display(Name = "Date checked out")]
        [DataType(DataType.Date)]
        public DateTime DateCheckedOut { get; set; }
        public int Doctor_Id { get; set; }
        public virtual DoctorVM Doctor { get; set; }

        public PatientVM()
        {
                
        }

        public PatientVM(PatientDTO patientDTO)
        {
            Patient_Id = patientDTO.Patient_Id;
            Name = patientDTO.Name;
            Insurance = patientDTO.Insurance;
            DateAdmitted = patientDTO.DateAdmitted;
            DateCheckedOut = patientDTO.DateCheckedOut;
            Doctor_Id = patientDTO.Doctor_Id;
        }
    }
}