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

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        // GET: MessageDefinition
        public ActionResult Index()
        {

            var csv_file_path = @"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\MessageDefinition.csv";
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            List<MessageDefinition> messageDefinitions = new List<MessageDefinition>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                MessageDefinition obj = new MessageDefinition();
                obj.Number = Convert.ToInt32(line[0]);
                obj.Title = line[1];
                obj.ComponentType = line[2];
                obj.Class = line[3];
                obj.Level = line[4];
                messageDefinitions.Add(obj);
            }
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(messageDefinitions);
            ViewBag.json = serializedResult;


            return View();
        }
    }
}