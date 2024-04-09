using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        GenericRepository<tbl_sosyal_medya> repo = new GenericRepository<tbl_sosyal_medya>();
        // GET: SosyalMedya
        public ActionResult Index()
        {
            var sosyalmedya=repo.List();
            return View(sosyalmedya);
        }

        [HttpGet]
        public ActionResult SosyalMedyaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SosyalMedyaEkle(tbl_sosyal_medya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SosyalMedyaDuzenle(int id)
        {
            var hesap = repo.Find(x=> x.sosyal_medya_id_PK==id);
            return View(hesap);
        }

        [HttpPost]
        public ActionResult SosyalMedyaDuzenle(tbl_sosyal_medya p)
        {
            var hesap = repo.Find(x=> x.sosyal_medya_id_PK==p.sosyal_medya_id_PK);
            hesap.ad = p.ad;
            hesap.durum = true;
            hesap.link = p.link;
            hesap.ikon = p.ikon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }

        public ActionResult SosyalMedyaSil(int id)
        {
            var hesap = repo.Find(x=>x.sosyal_medya_id_PK==id);
            hesap.durum = false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}