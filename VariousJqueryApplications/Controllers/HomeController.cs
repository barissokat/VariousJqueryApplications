using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VariousJqueryApplications.Models;

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

        public ActionResult SelectAllData()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "PC", Price = 1200 },
                new Product { Id = 2, Name = "Laptop", Price = 2200 },
                new Product { Id = 3, Name = "Tablet", Price = 3200 }
            };
            ViewBag.Products = products;
            return View();
        }

        [HttpPost]
        public void Delete(string selectedId)
        {

        }
    }
}