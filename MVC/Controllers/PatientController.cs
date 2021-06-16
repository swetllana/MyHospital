using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index(string SearchM = "")
        {
            List<PatientVM> patientsVM = new List<PatientVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetPatients(SearchM))
                {
                    patientsVM.Add(new PatientVM(item));
                }
            }

            return View(patientsVM);
        }

        public ActionResult Details(int id)
        {
            PatientVM patientVM = new PatientVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var patientDTO = service.GetPatientByID(id);
                patientVM = new PatientVM(patientDTO);
            }

            return View(patientVM);
        }
        public ActionResult Create()
        {
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientVM patientVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        PatientDTO patientDTO = new PatientDTO
                        {
                           Patient_Id = patientVM.Patient_Id,
                           Name = patientVM.Name,
                           Insurance = patientVM.Insurance,
                           DateAdmitted = patientVM.DateAdmitted,
                           DateCheckedOut= patientVM.DateCheckedOut,
                           Doctor_Id = patientVM.Doctor_Id
                        };
                        service.PostPatients(patientDTO);
                        return RedirectToAction("Index");
                    }
                }
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
            catch
            {
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            PatientVM patientVM = new PatientVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var patientDTO = service.GetPatientByID(id);
                patientVM = new PatientVM(patientDTO);
            }
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
            return View(patientVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientVM patientVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        PatientDTO patientDTO = new PatientDTO
                        {
                            Patient_Id = patientVM.Patient_Id,
                            Name = patientVM.Name,
                            Insurance = patientVM.Insurance,
                            DateAdmitted = patientVM.DateAdmitted,
                            DateCheckedOut = patientVM.DateCheckedOut,
                            Doctor_Id = patientVM.Doctor_Id
                        };
                        service.PutPatient(patientDTO);
                    }

                    return RedirectToAction("Index");
                }

                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
            catch
            {
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeletePatient(id);
            }

            return RedirectToAction("Index");
        }
    }
}