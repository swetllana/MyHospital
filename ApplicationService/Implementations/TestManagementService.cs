using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class TestManagementService
    {
        private HospitalDBContext ctx = new HospitalDBContext();

        public List<TestDTO> Get(string search)
        {

            List<TestDTO> testDTOs = new List<TestDTO>();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.TestRepository.Get(x => x.Id.ToString().Contains(search)))
                    testDTOs.Add(new TestDTO
                    {
                        Test_Id = item.Id,
                        Name = item.Name,
                        TestDate = item.TestDate,
                        TestTime = item.TestTime,
                        Result = item.Result,
                        Patient_Id = item.Patient_Id,
                        Doctor_Id= item.Doctor_Id
                    });
            }
            return testDTOs;
        }

        public TestDTO GetById(int id)
        {
            TestDTO testDTO = new TestDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Test test = unitOfWork.TestRepository.GetByID(id);
                if (test != null)
                {
                    testDTO.Test_Id = test.Id;
                    testDTO.Name = test.Name;
                    testDTO.TestDate = test.TestDate;
                    testDTO.TestTime = test.TestTime;
                    testDTO.Result = test.Result;
                    testDTO.Doctor_Id = test.Doctor_Id;
                    testDTO.Patient_Id = test.Patient_Id;
                }
            }
            return testDTO;
        }
        public bool Save(TestDTO testDTO)
        {
            if ((testDTO.Patient_Id <= 0 || testDTO.Patient_Id == null) || (testDTO.Doctor_Id <= 0 || testDTO.Doctor_Id == null))
            {
                return false;
            }

            Test test = new Test
            {
                Id = testDTO.Test_Id,
                Name = testDTO.Name,
                TestDate = testDTO.TestDate,
                TestTime = testDTO.TestTime,
                Result = testDTO.Result,
                Patient_Id = testDTO.Patient_Id,
                Doctor_Id = testDTO.Doctor_Id
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (testDTO.Test_Id == 0)
                        unitOfWork.TestRepository.Insert(test);
                    else
                        unitOfWork.TestRepository.Update(test);

                    unitOfWork.Save();
                }
                return true;
            }
            catch 
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Test test = unitOfWork.TestRepository.GetByID(id);
                    unitOfWork.TestRepository.Delete(test);
                    unitOfWork.Save();
                }
                return true;
            }
            catch 
            {

                return false;
            }
        }
    }
}
