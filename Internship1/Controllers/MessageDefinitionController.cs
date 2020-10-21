using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Internship1.Models;
using System.IO;
using Internship1.Service;

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        
        public ActionResult Download(string path)
        {
            //string fileName = Path.GetFileName(file.FileName);
            // string path = Path.Combine(Server.MapPath("~/App_Data/uploads/"), fileName);
            return File(path, "text/json", "File Result.json");
        }

        // GET: MessageDefinition
        public ActionResult Index(string path)
        {
            
            if (path != null)
            {
                ViewBag.name = path;
                List<ExportModel> en = Service.Import.ImportFileEn(path);
                List<ExportModel> de = Service.Import.ImportFileDe(path);
                List<ExportModel> es = Service.Import.ImportFileEs(path);
                List<ExportModel> fr = Service.Import.ImportFileFr(path);
                List<ExportModel> it = Service.Import.ImportFileIt(path);
                List<ExportModel> ja = Service.Import.ImportFileJa(path);
                List<ExportModel> pt = Service.Import.ImportFilePt(path);
                List<ExportModel> ru = Service.Import.ImportFileRu(path);
                List<ExportModel> zh = Service.Import.ImportFileZh(path);

                ViewBag.jsonen = ExportJson.Export(en, path);
                ViewBag.jsonde = ExportJson.Export(de, path);
                ViewBag.jsones = ExportJson.Export(es, path);
                ViewBag.jsonfr = ExportJson.Export(fr, path);
                ViewBag.jsonit = ExportJson.Export(it, path);
                ViewBag.jsonja = ExportJson.Export(ja, path);
                ViewBag.jsonpt = ExportJson.Export(pt, path);
                ViewBag.jsonru = ExportJson.Export(ru, path);
                ViewBag.jsonzh = ExportJson.Export(zh, path);

                //return File(path, "text/json", "File Result.json"));
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
        
      
        

    }  
}