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
        PersonManager _personManager=new PersonManager();
        public ActionResult SignUpPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpPage(Person person)
        {
            if (_personManager.AddPerson(person)==0)
            {
                return View(person);
            }
            else
            {
                return View();
            }
            
        }
	}
}