using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyCv.Models.Entity;
using MvcMyCv.Repostories;

namespace MvcMyCv.Controllers
{
    public class İletisimController : Controller
    {
        GenericRepository<tbl_iletisim> repo = new GenericRepository<tbl_iletisim>();
        // GET: İletisim
        public ActionResult Index()
        {
            var iletisim = repo.List();
            return View(iletisim);
        }
    }
}