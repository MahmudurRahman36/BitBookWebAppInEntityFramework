using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBookWebApplication.BLL;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.Controllers
{
    public class SignUpController : Controller
    {
        UserManager _userManager=new UserManager();
        public ActionResult SignUpPage()
        {
            List<Gender> genderList = _userManager.GetAllGenders();
            ViewBag.GenderList = genderList;
            return View();
        }
        [HttpPost]
        public ActionResult SignUpPage(User user)
        {
            List<Gender> genderList = _userManager.GetAllGenders();
            ViewBag.GenderList = genderList;
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            if (_userManager.IsUserEmailExist(user))
            {
                ViewBag.Message = "User Email Already related to an Account";
                return View(user);
            }
            if (_userManager.AddUser(user)==0)
            {
                ViewBag.Message = "Failed to add user data";
                return View(user);
            }
            else
            {
                return View();
            }            
        }

        public ActionResult AdditionInformationPage()
        {
            return View();
        }
	}
}