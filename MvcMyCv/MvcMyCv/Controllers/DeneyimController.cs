using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMyCv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
           return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(tbl_deneyim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimSil(int id)
        {
            tbl_deneyim t = repo.Find(x=> x.deneyim_id_PK==id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            tbl_deneyim t = repo.Find(x => x.deneyim_id_PK == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult DeneyimGetir(tbl_deneyim p)
        {
            tbl_deneyim t = repo.Find(x => x.deneyim_id_PK == p.deneyim_id_PK);
            t.baslik = p.baslik;
            t.alt_baslik = p.alt_baslik;
            t.tarih = p.tarih;
            t.aciklama = p.aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }


}