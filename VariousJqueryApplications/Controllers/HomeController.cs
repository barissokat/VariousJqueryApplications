using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VariousJqueryApplications.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost, ActionName("UploadFile")]
        public ActionResult MultipleUploadFile(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                if (file != null)
                {
                    string filePath = Path.GetFileName(file.FileName);
                    var uploadPath = Path.Combine(Server.MapPath("~/Files"), filePath);
                    file.SaveAs(uploadPath);
                }
            }
            return View();
        }
    }
}