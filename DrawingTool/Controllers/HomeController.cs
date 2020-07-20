using BusinessLayer;
using DrawingTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DrawingTool.Controllers
{
    public class HomeController : Controller
    {
        private IDraw _shape;

        public HomeController(IDraw shape)
        {
            this._shape = shape;
        }

        // GET: Canvas
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {

            BinaryReader b = new BinaryReader(file.InputStream);
            byte[] binData = b.ReadBytes(file.ContentLength);
            string result = System.Text.Encoding.UTF8.GetString(binData);
            string[] data = Utility.TextManager(result, "\n");
            return View(_shape.DrawShape(data));
        }

        public ActionResult About()
        {
            return View();
        }

    }
}