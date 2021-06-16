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
    public class UserManagementService
    {
        private HospitalDBContext ctx = new HospitalDBContext();

        public List<UserDTO> Get() 
        {
            List<UserDTO> user = new List<UserDTO>(); 

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.UserRepository.Get())
                {
                    user.Add(new UserDTO
                    {
                        User_Id = item.Id,
                        Name = item.Name,
                        Username = item.Username,
                        Password = item.Password,
                        ConfPassword = item.ConfPassword,
                        Email = item.Email,
                    });

                }

                return user;
            }
        }

        public UserDTO GetById(int id)
        {

            User user = ctx.Users.Find(id);

            UserDTO userDTO = new UserDTO
            {
                User_Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Password = user.Password,
                ConfPassword = user.ConfPassword,
                Email = user.Email

            };

            return userDTO;
        }


        public bool Save(UserDTO userDTO) 
        {

            User user = new User 
            {
                Id = userDTO.User_Id,
                Name = userDTO.Name,
                Username = userDTO.Username,
                Password = userDTO.Password,
                ConfPassword = userDTO.ConfPassword,
                Email = userDTO.Email
            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.UserRepository.Insert(user);
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
                    User user = unitOfWork.UserRepository.GetByID(id);
                    unitOfWork.UserRepository.Delete(user);
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
