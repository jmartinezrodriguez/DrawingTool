using BusinessLayer;
using DrawingTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrawingTool.Controllers
{
    public class HomeController : Controller
    {
        private IDraw _canva;

        public HomeController(IDraw canva)
        {
            this._canva = canva;
        }

        // GET: Canvas
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            BinaryReader b = new BinaryReader(file.InputStream);
            byte[] binData = b.ReadBytes(file.ContentLength);
            string result = System.Text.Encoding.UTF8.GetString(binData);
            string[] data = Utility.TextManager(result, "\n");
            //object canva = null;
            return View(Creator(data));
        }

        public ActionResult About()
        {
            return View();
        }
        //public ActionResult Index()
        //{
        //    return View(new CavasViewModel { X = 200, Y = 200 });
        //}



        public object Creator(string[] data)
        {
            Printer printer = new Printer();
            int width = 0;
            int height = 0;

            foreach (var item in data)
            {
                if (item.Contains("C"))
                {
                    string[] dataCanvas = Utility.TextManager(item, " ");
                    width = int.Parse(dataCanvas[1]);
                    height = int.Parse(dataCanvas[2]);
                    printer.canva = _canva.DrawCanva(dataCanvas[0], int.Parse(dataCanvas[1]), int.Parse(dataCanvas[2]), 0, 0);
                }

                if (item.Contains("L"))
                {
                    string[] dataLine = Utility.TextManager(item, " ");
                    printer.line = _canva.DrawLine(dataLine[0], width, height, int.Parse(dataLine[1]), int.Parse(dataLine[2]), int.Parse(dataLine[3]), int.Parse(dataLine[4]));
                }


                if (item.Contains("R"))
                {
                    string[] dataLine = Utility.TextManager(item, " ");
                    printer.rectangle = _canva.DrawRectangle(dataLine[0], width, height, int.Parse(dataLine[1]), int.Parse(dataLine[2]), int.Parse(dataLine[3]), int.Parse(dataLine[4]));
                }
            }

            return printer;
        }
    }
}