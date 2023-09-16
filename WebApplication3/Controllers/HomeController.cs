using Newtonsoft.Json.Linq;
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
            if (VerifyLogin())
                return View();
            else
                return View("Login2");
        }


        /// <summary>بررسی ورود به سیستم کاربر</summary>
        private bool VerifyLogin()
        {
            if (Session["login"] == null)
                return false;
            else
                return true;
            //var cookie = Request.Cookies["login"];
            //if (cookie == null)
            //    return false;
            //else
            //    return true;
        }


        public ActionResult Bootstrap()
        {
            if (VerifyLogin())
                return View();
            else
                return View("Login2");
        }

        public ActionResult sweetalert()
        {
            if (VerifyLogin())
                return View();
            else
                return View("Login2");
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
                Session["login"] = "mehrdad";
                //var cookie = new HttpCookie("login", username);
                ////Response.Cookies.Add(cookie);
                //Response.SetCookie(cookie);

                return Json(new { errorCode = "0", error = "" });
            }
            else
            {
                return Json(new { errorCode = "-1", error = "نام کاربری و رمز عبور اشتباه است" });
            }
        }


        public ActionResult signout()
        {
            Session["login"] = null;
            return View("login2");
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