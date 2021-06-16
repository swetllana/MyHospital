using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class DoctorVM
    {
        public int Doctor_Id { get; set; }
        [Required,StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(30)]
        public string Specialization { get; set; }
        public DoctorVM()
        {
                
        }

        public DoctorVM(DoctorDTO doctorDTO)
        {
            Doctor_Id = doctorDTO.Doctor_Id;
            Name = doctorDTO.Name;
            Specialization = doctorDTO.Specialization;
        }
    }
}