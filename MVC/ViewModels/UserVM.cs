using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class UserVM
    {
        public int User_Id { get; set; }
        [Required,StringLength(40)]
        public string Name { get; set; }
        [Required, StringLength(40)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfPassword { get; set; }
        [Required, StringLength(40)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public UserVM()
        {

        }
        public UserVM(UserDTO user)
        {
            User_Id = user.User_Id;
            Name = user.Name;
            Username = user.Username;
            Email = user.Email;
            Password = user.Password;
            ConfPassword = user.ConfPassword;
        }
    }
}