using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserVM> userVM = new List<UserVM>();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetUsers())
                {
                    userVM.Add(new UserVM(item));
                }
            }
            return View(userVM);

        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserVM user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        UserDTO userDTO = new UserDTO
                        {
                            User_Id = user.User_Id,
                            Name = user.Name,
                            Username = user.Username,
                            Password = user.Password,
                            ConfPassword = user.ConfPassword,
                            Email = user.Email,

                        };

                        service.PostUsers(userDTO);
                    }

                    return RedirectToAction("Index");

                }
                return View();
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Details(int id)
        {
            UserVM userVM = new UserVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var userDTO = service.GetUserByID(id);
                userVM = new UserVM(userDTO);
            }

            return View(userVM);

        }

        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteUser(id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(UserVM model)
        {
            FormsAuthentication.SetAuthCookie(model.Username, false);
            return RedirectToAction("Index", "Home");
            //using (var ctx = new HospitalDBContext())
            //{

            //    bool isValid = ctx.Users.Any(x => model.Username == x.Username);
            //                                   //   && x.Password == model.Password);

            // //   if (isValid)
            // //   {
            //        FormsAuthentication.SetAuthCookie(model.Username, false);
            //        return RedirectToAction("Index", "Home");
            ////    }
            //    //else
            //    //{
            //    //    ModelState.AddModelError("AuthenticationFailed", "Wrong Username or Password");
            //    //    return View(model);
            //    //}


            //}
            ////ModelState.AddModelError("", "Invalid username or password!");
            ////  return View(model);

        }
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //public ActionResult Edit(UserVM item)
        //{
        //    MyDataBaseContex ctx = new MyDataBaseContex();

        //    //User item = ctx.Users
        //    //                    .Where(u => u.Id == id)
        //    //                    .FirstOrDefault();

        //    //if (item == null)
        //    //    return RedirectToAction("Index", "User");

        //    UserVM model = new UserVM();
        //    model.Id = item.Id;
        //    model.Name = item.Name;
        //    model.Username = item.Username;
        //    model.Password = item.Password;
        //    model.Email = item.Email;


        //    ctx.Users.Update(model);
        //    ctx.SaveChanges();

        //    return RedirectToAction("Index","User");

        //}
    }
}