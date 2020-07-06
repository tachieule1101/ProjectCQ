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
            return View();
        }

        public ActionResult TienDoMLNS()
        {
            QLtableDSML ql = new QLtableDSML();
            List<QLTienDoMLNS> obj = ql.get(); //get là hàm bên Model/QLTienDoMLNS.cs
            return View(obj);
        }
        public ActionResult TienDoCBQL()
        {
            QLtableDS ql = new QLtableDS();
            List<QLTienDoCBQL> obj = ql.get(); //get là hàm bên Model/QLTienDoCBQL.cs
            return View(obj);
        }
    }
}