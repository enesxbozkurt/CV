using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    
    public class HakkimdaController : Controller
    {
        GenericRepository<tbl_hakkimda> repo = new GenericRepository<tbl_hakkimda>();
        // GET: Hakkimda
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(tbl_hakkimda p)
        {
            var hakkimda = repo.Find(x=>x.hakkimda_id_PK==1);
            hakkimda.isim = p.isim;
            hakkimda.soyisim = p.soyisim;
            hakkimda.adres = p.adres;
            hakkimda.telefon = p.telefon;
            hakkimda.mail = p.mail;
            hakkimda.aciklama = p.aciklama;
            hakkimda.resim = p.resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}