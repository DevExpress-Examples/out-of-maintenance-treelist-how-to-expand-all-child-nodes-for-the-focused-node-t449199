using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeList_Sample.Models;

namespace TreeList_Sample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult TreeListPartial(bool? Expand) {
            ViewData["Expand"] = Expand;
            return PartialView(DepartmentsProvider.GetDepartments());
        }
    }
}