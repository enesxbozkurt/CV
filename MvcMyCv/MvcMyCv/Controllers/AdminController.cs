using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<tbl_giris> repo = new GenericRepository<tbl_giris>();

        public ActionResult Index()
        {
            var admin = repo.List();
            return View(admin);
        }

        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            var admin = repo.Find(x => x.giris_id_PK == id);
            return View(admin);

        }
        [HttpPost]
        public ActionResult AdminDuzenle(tbl_giris p)
        {
            if (!ModelState.IsValid)
            {
                return View("AdminDuzenle");
            }
            var e = repo.Find(x => x.giris_id_PK == p.giris_id_PK);
            e.kullanici_adi = p.kullanici_adi;
            e.sifre = p.sifre;
            repo.TUpdate(e);
            return RedirectToAction("Index");

        }

        public ActionResult AdminSil(int id)
        {
            var admin = repo.Find(x => x.giris_id_PK == id);
            repo.TDelete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(tbl_giris p)
        {
            if (!ModelState.IsValid)
            {
                return View("AdminEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");

        }
    }
}