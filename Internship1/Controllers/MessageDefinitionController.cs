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
                MessageDefinition obj = new MessageDefinition()
                {
                    Number = Convert.ToInt32(line[0]),
                    Title = line[1],
                    ComponentType = line[2],
                    Class = line[3],
                    Level = line[4],
                    AckMode = line[5],
                    SystemReactionMode = line[6],
                    DisplayTitle = new DisplayTitle()
                    {
                        En = line[7]
                    },
                    DisplayDetails = new DisplayDetails()
                    {
                        En = line[16]
                    },
                    Param1 = new Param()
                    {
                        DataType = line[26]
                    },
                    Param2 = new Param()
                    {
                        Description=line[29]
                    },
                    Param3 = new Param() 
                    {
                        Unit = line[35]
                    }


                };
                messageDefinitions.Add(obj);
            }
               
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(messageDefinitions);
            string json_pretty = JSON_PrettyPrinter.Process(serializedResult);
            ViewBag.json = serializedResult;

            System.IO.File.WriteAllText(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\novo.json", json_pretty);

            
            
             return View();
        }

    }
}