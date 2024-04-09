using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;

namespace MvcMyCv.Controllers
{
    public class DefaultController : Controller
    {
        db_cvEntities db = new db_cvEntities();
        // GET: Default
        public ActionResult Index()
        {
            
            var degerler = db.tbl_hakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.tbl_sosyal_medya.Where(x=>x.durum==true).ToList();
            return PartialView(sosyalmedya);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.tbl_deneyim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitim = db.tbl_egitim.ToList();
            return PartialView(egitim);
        }

        public PartialViewResult Yetenek()
        {
            var yetenek = db.tbl_yetenek.ToList();
            return PartialView(yetenek);
        }

        public PartialViewResult Hobi()
        {
            var hobi = db.tbl_hobi.ToList();
            return PartialView(hobi);
        }

        public PartialViewResult Sertifika()
        {
            var sertifika = db.tbl_sertifika.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(tbl_iletisim d)
        {
            d.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.tbl_iletisim.Add(d);
            db.SaveChanges();
            return PartialView();
        }
    }
}