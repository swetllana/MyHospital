using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string SearchUM = "")
        {
            List<TestVM> testVMs = new List<TestVM>();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetTests(SearchUM))
                {
                    testVMs.Add(new TestVM(item));
                }
            }
            return View(testVMs);
        }

        public ActionResult Details(int id)
        {
            TestVM testVM = new TestVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var testDTO = service.GetTestByID(id);
                testVM = new TestVM(testDTO);
            }
            return View(testVM);
        }
        public ActionResult Create()
        {
            ViewBag.Patients = Helpers.LoadDataUtilities.LoadPatientDataList();
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TestVM testVM)
        {
            try
            {
                using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                {
                    TestDTO testDTO = new TestDTO
                    {
                          Test_Id = testVM.Test_Id,
                          Name = testVM.Name,
                          TestDate = testVM.TestDate,
                          TestTime = testVM.TestTime,
                          Result = testVM.Result,
                          Patient_Id = testVM.Patient_Id,
                          Doctor_Id = testVM.Doctor_Id
                    };
                    service.PostTests(testDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Patients = Helpers.LoadDataUtilities.LoadPatientDataList();
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }

        }

        public ActionResult Edit(int id)
        {
            TestVM testVM = new TestVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var testDTO = service.GetTestByID(id);
                testVM = new TestVM(testDTO);
            }
            ViewBag.Patients = Helpers.LoadDataUtilities.LoadPatientDataList();
            ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
            return View(testVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TestVM testVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        TestDTO testDTO = new TestDTO
                        {
                            Test_Id = testVM.Test_Id,
                            Name = testVM.Name,
                            TestDate = testVM.TestDate,
                            TestTime = testVM.TestTime,
                            Result = testVM.Result,
                            Patient_Id = testVM.Patient_Id,
                            Doctor_Id = testVM.Doctor_Id
                        };
                        service.PutTest(testDTO);
                    }

                    return RedirectToAction("Index");
                }

                ViewBag.Patients = Helpers.LoadDataUtilities.LoadPatientDataList();
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
            catch
            {
                ViewBag.Patients = Helpers.LoadDataUtilities.LoadPatientDataList();
                ViewBag.Doctors = Helpers.LoadDataUtilities.LoadDoctorDataList();
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteTest(id);
            }

            return RedirectToAction("Index");
        }
    }
}