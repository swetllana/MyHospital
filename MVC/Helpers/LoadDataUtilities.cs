using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Helpers
{
    public class LoadDataUtilities
    {
        public static SelectList LoadDoctorDataList()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetDoctors(""), "Doctor_Id", "Name");

            }
        }
        public static SelectList LoadPatientDataList()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetPatients(""), "Patient_Id", "Name");
            }
        }

    }
}