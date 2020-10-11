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
             List<MessageDefinition> list = Import.ImportFile();
             ViewBag.json = ExportJson.ExportJSON(list);
            
             return View();
        }

    }
}