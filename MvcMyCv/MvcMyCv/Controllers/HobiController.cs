using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    public class HobiController : Controller
    {
        GenericRepository<tbl_hobi> repo = new GenericRepository<tbl_hobi>();
        // GET: Hobi
        public ActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }

        [HttpGet]
        public ActionResult HobiGuncelle(int id)
        {
            var hobi=repo.Find(x=>x.hobi_id_PK==id);
            ViewBag.d = id;
            return View(hobi);
        }

        [HttpPost]
        public ActionResult HobiGuncelle(tbl_hobi p)
        {
            var hobi = repo.Find(x => x.hobi_id_PK == p.hobi_id_PK);
            hobi.aciklama_1 = p.aciklama_1;
            hobi.aciklama_2 = p.aciklama_2;
            repo.TUpdate(hobi);
            return RedirectToAction("Index");
        }
        public ActionResult HobiSil(int id)
        {
            var hobi = repo.Find(x => x.hobi_id_PK == id);
            repo.TDelete(hobi);
            return RedirectToAction("Index");
        }
    }
}