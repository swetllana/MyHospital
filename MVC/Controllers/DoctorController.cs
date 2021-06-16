using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index(string SearchM = "")
        {
            List<DoctorVM> doctorsVM = new List<DoctorVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetDoctors(SearchM))
                {
                    doctorsVM.Add(new DoctorVM(item));
                }
            }
            return View(doctorsVM);
        }

        public ActionResult Create()
        {
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DoctorVM doctorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        DoctorDTO doctorDTO = new DoctorDTO
                        {
                            Doctor_Id = doctorVM.Doctor_Id,
                            Name = doctorVM.Name,
                            Specialization = doctorVM.Specialization
                        };
                        service.PostDoctors(doctorDTO);

                        return RedirectToAction("Index");
                    }
                }
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();          
            }
            catch (Exception)
            {
                return View();
            }
           
        }

        public ActionResult Edit(int id)
        {
            DoctorVM doctorVM = new DoctorVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var doctorDTO = service.GetDoctorByID(id);
                doctorVM = new DoctorVM(doctorDTO);
            }
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
            return View(doctorVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DoctorVM doctorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        DoctorDTO doctorDTO = new DoctorDTO
                        {
                          Doctor_Id = doctorVM.Doctor_Id,
                          Name = doctorVM.Name,
                          Specialization = doctorVM.Specialization
                        };
                        service.PostDoctors(doctorDTO);
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


        public ActionResult Details(int id)
        {
            DoctorVM doctorVM = new DoctorVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var doctorDto = service.GetDoctorByID(id);
                doctorVM = new DoctorVM(doctorDto);
            }
            return View(doctorVM);
        }

        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteDoctor(id);
            }

            return RedirectToAction("Index");
        }
    }
}