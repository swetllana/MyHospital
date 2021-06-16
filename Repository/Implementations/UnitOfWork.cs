using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private HospitalDBContext context = new HospitalDBContext();
        private GenericRepository<Doctor> doctorRepository;
        private GenericRepository<Patient> patientRepository;
        private GenericRepository<Test> testRepository;
        private GenericRepository<User> userRepository;


        public GenericRepository<Doctor> DoctorRepository
        {
            get
            {

                if (this.doctorRepository == null)
                {
                    this.doctorRepository = new GenericRepository<Doctor>(context);
                }
                return doctorRepository;
            }
        }

        public GenericRepository<Patient> PatientRepository
        {
            get
            {

                if (this.patientRepository == null)
                {
                    this.patientRepository = new GenericRepository<Patient>(context);
                }
                return patientRepository;
            }
        }
        public GenericRepository<Test> TestRepository
        {
            get
            {

                if (this.testRepository == null)
                {
                    this.testRepository = new GenericRepository<Test>(context);
                }
                return testRepository;
            }
        }

        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
