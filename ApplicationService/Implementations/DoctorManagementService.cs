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
    public class DoctorManagementService
    {
        private HospitalDBContext ctx = new HospitalDBContext();

        public List<DoctorDTO> Get(string search)
        {
            List<DoctorDTO> doctorsDTO = new List<DoctorDTO>();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.DoctorRepository.Get(x => x.Name.Contains(search)))
                {
                    doctorsDTO.Add(new DoctorDTO
                    {
                        Doctor_Id = item.Id,
                        Name = item.Name,
                        Specialization = item.Specialization
                    });
                }
            }
            return doctorsDTO;
        }
        public DoctorDTO GetById(int id)
        {
            DoctorDTO doctorDTO = new DoctorDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Doctor doctor = unitOfWork.DoctorRepository.GetByID(id);
                if (doctor != null)
                {
                    doctorDTO.Doctor_Id = doctor.Id;
                    doctorDTO.Name = doctor.Name;
                    doctorDTO.Specialization = doctor.Specialization;
                }
            }
            return doctorDTO;
        }
        public bool Save(DoctorDTO doctorDTO)
        {
            Doctor doctor = new Doctor
            {
                Id = doctorDTO.Doctor_Id,
                Name = doctorDTO.Name,
                Specialization = doctorDTO.Specialization
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (doctorDTO.Doctor_Id == 0)
                        unitOfWork.DoctorRepository.Insert(doctor);
                    else
                        unitOfWork.DoctorRepository.Update(doctor);

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
                    Doctor doctor = unitOfWork.DoctorRepository.GetByID(id);
                    unitOfWork.DoctorRepository.Delete(doctor);
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
