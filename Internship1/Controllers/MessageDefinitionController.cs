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

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        // GET: MessageDefinition
        public ActionResult Index()
        {
            List<ExportModel> en = Import.ImportFileEn(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> de = Import.ImportFileDe(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> es = Import.ImportFileEs(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> fr = Import.ImportFileFr(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> it = Import.ImportFileIt(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> ja = Import.ImportFileJa(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> pt = Import.ImportFilePt(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> ru = Import.ImportFileRu(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");
            List<ExportModel> zh = Import.ImportFileZh(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv");


            List<string> listOfPaths = new List<string>()
            {
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\en-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\de-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\es-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\fr-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\it-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\ja-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\pt-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\ru-new.json",
            @"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\zh-new.json"
            };
            ViewBag.jsonen = ExportJson.Export(en, listOfPaths[0]);
            ViewBag.jsonde = ExportJson.Export(de, listOfPaths[1]);
            ViewBag.jsones = ExportJson.Export(es, listOfPaths[2]);
            ViewBag.jsonfr = ExportJson.Export(fr, listOfPaths[3]);
            ViewBag.jsonit = ExportJson.Export(it, listOfPaths[4]);
            ViewBag.jsonja = ExportJson.Export(ja, listOfPaths[5]);
            ViewBag.jsonpt = ExportJson.Export(pt, listOfPaths[6]);
            ViewBag.jsonru = ExportJson.Export(ru, listOfPaths[7]);
            ViewBag.jsonzh = ExportJson.Export(zh, listOfPaths[8]);
           

            return View();
        }

    }
}