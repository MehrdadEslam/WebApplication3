using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login2()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult checkLogin(string username, string password)
        {
            if (username == "mehrdad" && password == "123456")
            {
                return Json(new { errorCode = "0", error = "" });
            }
            else
            {
                return Json(new { errorCode = "-1"  , error="نام کاربری و رمز عبور اشتباه است"});
            }
        }

        [HttpPost]
        public ActionResult getData(string a)
        {
            if (a == "test")
            {
                return Json(new { success = "ورود موفق" });
            }
            else
            {
                return Json(new { error = "نام کاربری و رمز  " + a + "  صحیح نمی باشد" });
            }
        }
    }

}