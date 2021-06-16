using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class TestDTO
    {
        public int Test_Id { get; set; }
        public string Name { get; set; }
        public DateTime TestDate { get; set; }
        public DateTime TestTime { get; set; }
        public string Result { get; set; }
        public int Patient_Id { get; set; }
        public virtual PatientDTO Patient { get; set; }

        public int Doctor_Id { get; set; }
        public virtual DoctorDTO Doctor { get; set; }

    }
}
