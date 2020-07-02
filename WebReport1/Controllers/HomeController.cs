using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReport1.Models;
namespace WebReport1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DanhBa()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TienDoMLNS()
        {
            QLtableListMLNS ql = new QLtableListMLNS();
            List<TienDoMLNS> obj = ql.getTienDoMLNS();
            return View(obj);

        }
        public ActionResult TienDoCBQL()
        {
            QLtableList ql = new QLtableList();
            List<TienDo> obj = ql.getTienDo();
            return View(obj);
        }
    }
}