using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        private DoctorManagementService doctorService = new DoctorManagementService();
        public DoctorDTO GetDoctorByID(int id)
        {
            return doctorService.GetById(id);
        }

        public List<DoctorDTO> GetDoctors(string search)
        {
            return doctorService.Get(search);
        }
        private PatientManagementService patientService = new PatientManagementService();
        public PatientDTO GetPatientByID(int id)
        {
            return patientService.GetById(id);
        }

        public List<PatientDTO> GetPatients(string search)
        {
            return patientService.Get(search);
        }

        private TestManagementService testService = new TestManagementService();

        public TestDTO GetTestByID(int id)
        {

            return testService.GetById(id);
        }

        public List<TestDTO> GetTests(string search)
        {
            return testService.Get(search);
        }

        public string PostDoctors(DoctorDTO doctorDTO)
        {
            if (!doctorService.Save(doctorDTO))
            {
                return "Doctor is not saved!";
            }
            else
            {
                return "Doctor is saved!";
            }

        }

        public string PostPatients(PatientDTO patientDTO)
        {
            if (!patientService.Save(patientDTO))
            {
                return "Patient is not saved!";
            }
            else
            {
                return "Patient is saved!";
            }
        }

        public string PostTests(TestDTO testDTO)
        {
            if (!testService.Save(testDTO))
            {
                return "Test is not saved!";
            }
            else
            {
                return "Test is saved!";
            }
        }

        public string PutDoctor(DoctorDTO doctorDTO)
        {
            if (!doctorService.Save(doctorDTO))
            {
                return "Doctor is not updated!";
            }
            else
            {
                return "Doctor is updated!";
            }
        }

        public string PutPatient(PatientDTO patientDTO)
        {
            if (!patientService.Save(patientDTO))
            {
                return "Patient is not updated!";
            }
            else
            {
                return "Patient is updated!";
            }
        }

        public string PutTest(TestDTO testDto)
        {
            if (!testService.Save(testDto))
            {
                return "Test is not updated!";
            }
            else
            {
                return "Test is updated!";
            }
        }

        public string DeleteDoctor(int id)
        {
            if (!doctorService.Delete(id))
            {
                return "Doctor is not deleted!";
            }
            else
            {
                return "Doctor is deleted!";
            }
        }

        public string DeletePatient(int id)
        {
            if (!patientService.Delete(id))
            {
                return "Patient is not deleted!";
            }
            else
            {
                return "Patient is deleted!";
            }
        }

        public string DeleteTest(int id)
        {
            if (!testService.Delete(id))
            {
                return "Test is not deleted!";
            }
            else
            {
                return "Test is deleted!";
            }
        }
        private UserManagementService userService = new UserManagementService();
        public List<UserDTO> GetUsers()
        {
            return userService.Get();
        }

        public UserDTO GetUserByID(int id)
        {
            return userService.GetById(id);
        }

        public string PostUsers(UserDTO userDTO)
        {
            if (!userService.Save(userDTO))
            {
                return "User is not saved!";
            }
            else
            {
                return "User is saved!";
            }
        }

        public string DeleteUser(int id)
        {
            if (!userService.Delete(id))
            {
                return "User is not deleted!";
            }
            else
            {
                return "User is deleted!";
            }
        }
    }
}
