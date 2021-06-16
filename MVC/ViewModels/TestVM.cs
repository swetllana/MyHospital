using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class TestVM
    {
        public int Test_Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Test data")]
        [DataType(DataType.Date)]
        public DateTime TestDate { get; set; }
        [Required]
        [Display(Name = "Test time")]
        [DataType(DataType.Time)]
        public DateTime TestTime { get; set; }
        [Required, StringLength(300)]
        public string Result { get; set; }
        public int Patient_Id { get; set; }
        public virtual PatientVM Patient { get; set; }

        public int Doctor_Id { get; set; }
        public virtual DoctorVM Doctor { get; set; }

        public TestVM()
        {

        }

        public TestVM(TestDTO testDTO)
        {
            Test_Id = testDTO.Test_Id;
            Name = testDTO.Name;
            TestDate = testDTO.TestDate;
            TestTime = testDTO.TestTime;
            Result = testDTO.Result;
            Patient_Id = testDTO.Patient_Id;
            Doctor_Id = testDTO.Doctor_Id;
        }
    }
}