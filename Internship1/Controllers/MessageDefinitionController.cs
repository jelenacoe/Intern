using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using Internship1.Models;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Internship1.Service;
using Antlr.Runtime.Tree;
using System.Text.Json;
using Microsoft.Win32;

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        // GET: MessageDefinition
        public ActionResult Index(string path)
        {
            if (path != null)
            {
                ViewBag.name = path;
                List<ExportModel> en = Import.ImportFileEn(path);
                List<ExportModel> de = Import.ImportFileDe(path);
                List<ExportModel> es = Import.ImportFileEs(path);
                List<ExportModel> fr = Import.ImportFileFr(path);
                List<ExportModel> it = Import.ImportFileIt(path);
                List<ExportModel> ja = Import.ImportFileJa(path);
                List<ExportModel> pt = Import.ImportFilePt(path);
                List<ExportModel> ru = Import.ImportFileRu(path);
                List<ExportModel> zh = Import.ImportFileZh(path);

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





            /* List<ExportModel> newen = Import.ImportFileEn(filepath);
             List<ExportModel> newde = Import.ImportFileDe(filepath);
             List<ExportModel> newes = Import.ImportFileEs(filepath);
             List<ExportModel> newfr = Import.ImportFileFr(filepath);
             List<ExportModel> newit = Import.ImportFileIt(filepath);
             List<ExportModel> newja = Import.ImportFileJa(filepath);
             List<ExportModel> newpt = Import.ImportFilePt(filepath);
             List<ExportModel> newru = Import.ImportFileRu(filepath);
             List<ExportModel> newzh = Import.ImportFileZh(filepath);

             var exporten = ExportJson.Export(newen,filepath);
             var exportde = ExportJson.Export(newde, filepath);
             var exportes = ExportJson.Export(newes, filepath);
             var exportfr = ExportJson.Export(newfr, filepath);
             var exportit = ExportJson.Export(newit, filepath);
             var exportja = ExportJson.Export(newja, filepath);
             var exportpt = ExportJson.Export(newpt, filepath);
             var exportru = ExportJson.Export(newru, filepath);
             var exportzh = ExportJson.Export(newzh, filepath);*/




            return View();
        }
        [HttpPost]
        public ActionResult Read(HttpPostedFileBase file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
            file.SaveAs(path);
            return RedirectToAction("Index", new { path = path });


        }
        /* private void button1_Click(object sender, System.EventArgs e, List<ExportModel>)
         {
             // Displays a SaveFileDialog so the user can save the Image
             // assigned to Button2.
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             saveFileDialog1.Filter = "csvfile|*.csv";
             saveFileDialog1.Title = "Save a .csv File";
             saveFileDialog1.ShowDialog();
             string filepath = "~/App_Data/uploads";
             newen = Import.ImportFileEn(filepath);




             // If the file name is not an empty string open it for saving.
             if (saveFileDialog1.FileName != "")
             {

                 // Saves the Image via a FileStream created by the OpenFile method.
                 System.IO.FileStream fs =
                     (System.IO.FileStream)saveFileDialog1.OpenFile();
                 // Saves the Image in the appropriate ImageFormat based upon the
                 // File type selected in the dialog box.
                 // NOTE that the FilterIndex property is one-based.
                 switch (saveFileDialog1.FilterIndex)
                 {
                     case 1:
                         this.button2.Image.Save(fs,ExportJson.);
                         break;
                 }

                 fs.Close();
             }
             /* HomeViewModel model = new HomeViewModel { FileAttach = null, Data = new DataTable(), HasHeader = true };  

                  try  
                  {  
                      // Initialization.  
                      string filePath = "~/Content/temp_upload_files/download.csv";  

                      // Info.  
                      return this.GetFile(filePath);
                 }  
                  catch (Exception ex)  
                  {  
                      // Info  
                      Console.Write(ex);  
                  }

            // Info.  
               return this.View(model);  */

    }   //}
}