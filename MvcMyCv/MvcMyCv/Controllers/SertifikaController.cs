using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Repostories;
using MvcMyCv.Models.Entity;

namespace MvcMyCv.Controllers
{
    public class SertifikaController : Controller
    {
        GenericRepository<tbl_sertifika> repo = new GenericRepository<tbl_sertifika>();

        // GET: Sertifika
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }

        [HttpGet]
        public ActionResult SertifikaGuncelle(int id)
        {
            var sertifika = repo.Find(x=> x.sertifika_id_PK==id);
            ViewBag.d = id;
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaGuncelle(tbl_sertifika t)
        {
            if (!ModelState.IsValid)
            {
                return View("SertifikaGuncelle");
            }
            var s = repo.Find(x=> x.sertifika_id_PK==t.sertifika_id_PK);
            s.aciklama = t.aciklama;
            s.tarih = t.tarih;
            repo.TUpdate(s);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SertifikaEkle(/*int id*/)
        {
            /*var sertifika = repo.Find(x=> x.sertifika_id_PK==id);*/
            return View(/*sertifika*/);
        }

        [HttpPost]
        public ActionResult SertifikaEkle(tbl_sertifika p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x=> x.sertifika_id_PK==id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}