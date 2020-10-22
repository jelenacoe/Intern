using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Internship1.Models;
using System.IO;
using Internship1.Service;
using System;
using Internship1.Interfaces;

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        private IReadInterface reader;

        public class FileReader : IReadInterface
        {
            public string[] readFile(string path)
            {

                string[] lines = System.IO.File.ReadAllLines(path);
                return lines;
            }
        }

        public MessageDefinitionController()
        {
            this.reader = new FileReader();
        }

        public MessageDefinitionController(IReadInterface fileReader)
        {
            this.reader = fileReader;
        }


        // GET: File download

        public void Resolve(string text,string filename)
        {
            if (filename == null)
                filename = "file";
            Response.Clear();
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + ".json");
            Response.AppendHeader("Content-Length", text.Length.ToString());
            Response.ContentType = "text/json";
            Response.Write(text);
            Response.Flush();
        }


        public ActionResult Index(string path)
        {
    
            if (path != null)
            {

                string fileName = Path.GetFileName(path);
                try {
                path = Path.Combine(Server.MapPath("~/App_Data/uploads/"), fileName);
                }catch(Exception) {}
              
                string[] lines = reader.readFile(path);
                ViewBag.name = path;
                List<ExportModel> en = Service.ImportService.ImportFileEn(lines);
                List<ExportModel> de = Service.ImportService.ImportFileDe(lines);
                List<ExportModel> es = Service.ImportService.ImportFileEs(lines);
                List<ExportModel> fr = Service.ImportService.ImportFileFr(lines);
                List<ExportModel> it = Service.ImportService.ImportFileIt(lines);
                List<ExportModel> ja = Service.ImportService.ImportFileJa(lines);
                List<ExportModel> pt = Service.ImportService.ImportFilePt(lines);
                List<ExportModel> ru = Service.ImportService.ImportFileRu(lines);
                List<ExportModel> zh = Service.ImportService.ImportFileZh(lines);

                ViewBag.jsonen = ExportJson.Export(en, path);
                ViewBag.jsonde = ExportJson.Export(de, path);
                ViewBag.jsones = ExportJson.Export(es, path);
                ViewBag.jsonfr = ExportJson.Export(fr, path);
                ViewBag.jsonit = ExportJson.Export(it, path);
                ViewBag.jsonja = ExportJson.Export(ja, path);
                ViewBag.jsonpt = ExportJson.Export(pt, path);
                ViewBag.jsonru = ExportJson.Export(ru, path);
                ViewBag.jsonzh = ExportJson.Export(zh, path);



            }
            /*UserDownload endownload = new UserDownload();
            endownload.Download_Click(en,);*/



            return View();
        }

        [HttpPost]
        public ActionResult Read(HttpPostedFileBase file)
        {
            //potencial case 
            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("~/App_Data/uploads/"), fileName);
            file.SaveAs(path);

            return RedirectToAction("Index", new { path = path });


        }



        // Intereface for mocking





    }
}