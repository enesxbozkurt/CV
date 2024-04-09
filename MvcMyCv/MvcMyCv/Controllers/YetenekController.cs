using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepository<tbl_yetenek> repo = new GenericRepository<tbl_yetenek>();

        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(tbl_yetenek p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x=>x.yetenek_id_PK==id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            var yetenek = repo.Find(x=>x.yetenek_id_PK==id);
            return View(yetenek);

        }

        [HttpPost]
        public ActionResult YetenekDuzenle(tbl_yetenek t)
        {
            var yetenek = repo.Find(x=>x.yetenek_id_PK==t.yetenek_id_PK);
            yetenek.yetenek_adi = t.yetenek_adi;
            yetenek.oran = t.oran;
            repo.TUpdate(yetenek);
            return RedirectToAction("Index");
        }
    }
}