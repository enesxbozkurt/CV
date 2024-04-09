using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tbl_giris p)
        {
            db_cvEntities db = new db_cvEntities();
            var bilgi = db.tbl_giris.FirstOrDefault(x=>x.kullanici_adi==p.kullanici_adi&&x.sifre==p.sifre);
            if (bilgi !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.kullanici_adi,false);
                Session["kullanici_adi"] = bilgi.kullanici_adi.ToString();
                return RedirectToAction("Index","Hakkimda");
            }
            else
            {
                return RedirectToAction("Index", "Login");

            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}