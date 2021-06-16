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
    public class PatientManagementService
    {
        private HospitalDBContext ctx = new HospitalDBContext();

        public List<PatientDTO> Get(string search)
        {
            List<PatientDTO> patientsDTO = new List<PatientDTO>();
          
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.PatientRepository.Get(x => x.Name.Contains(search)))
                {
                    patientsDTO.Add(new PatientDTO
                    {
                        Patient_Id = item.Id,
                        Name = item.Name,
                        Insurance = item.Insurance,
                        DateAdmitted = item.DateAdmitted,
                        DateCheckedOut = item.DateCheckedOut,
                        Doctor_Id = item.Doctor_Id
                    });
                }
            }
            return patientsDTO;
        }

        public PatientDTO GetById(int id)
        {
            PatientDTO patientDTO = new PatientDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Patient patient = unitOfWork.PatientRepository.GetByID(id);
                if (patient != null)
                {
                    patientDTO.Patient_Id = patient.Id;
                    patientDTO.Name = patient.Name;
                    patientDTO.Insurance = patient.Insurance;
                    patientDTO.DateAdmitted = patient.DateAdmitted;
                    patientDTO.DateCheckedOut = patient.DateCheckedOut;
                    patientDTO.Doctor_Id = patient.Doctor_Id;
                }
            }
            return patientDTO;
        }
        public bool Save(PatientDTO patientDTO)
        {
            Patient patient = new Patient
            {
               Id = patientDTO.Patient_Id,
               Name = patientDTO.Name,
               Insurance = patientDTO.Insurance,
               DateAdmitted = patientDTO.DateAdmitted,
               DateCheckedOut = patientDTO.DateCheckedOut,
               Doctor_Id = patientDTO.Doctor_Id
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (patientDTO.Patient_Id == 0)
                        unitOfWork.PatientRepository.Insert(patient);
                    else
                        unitOfWork.PatientRepository.Update(patient);

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
                    Patient patient = unitOfWork.PatientRepository.GetByID(id);
                    unitOfWork.PatientRepository.Delete(patient);
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
