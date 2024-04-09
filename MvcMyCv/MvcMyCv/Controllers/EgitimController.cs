using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMyCv.Controllers
{
    public class EgitimController : Controller
    {
        GenericRepository<tbl_egitim> repo = new GenericRepository<tbl_egitim>();

        // GET: Egitim
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EgitimEkle(tbl_egitim p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");

        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x=> x.egitim_id_PK==id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x=> x.egitim_id_PK==id);
            return View(egitim);

        }
        [HttpPost]
        public ActionResult EgitimDuzenle(tbl_egitim t)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var e = repo.Find(x => x.egitim_id_PK == t.egitim_id_PK);
            e.baslik = t.baslik;
            e.alt_baslik = t.alt_baslik;
            e.alt_baslik_2 = t.alt_baslik_2;
            e.gnortalama = t.gnortalama;
            e.tarih = t.tarih;
            repo.TUpdate(e);
            return RedirectToAction("Index");

        }
    }
}