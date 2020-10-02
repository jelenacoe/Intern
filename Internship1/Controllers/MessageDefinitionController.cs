using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using Internship1.Models;
using System.IO;
using Newtonsoft.Json;

namespace Internship1.Controllers
{
    public class MessageDefinitionController : Controller
    {
        // GET: MessageDefinition
        [HttpPost]
        public ActionResult Index()
        {
           //string jsonResult = "";
            //List<MessageDefinition> messageDefinitions = new List<MessageDefinition>()
           


            var csv_file_path = @"C:\Users\Korisnik\Desktop\MessageDefinition.csv";
            string text = System.IO.File.ReadAllText(csv_file_path);

            var lines = text.Split(',');
            List<MessageDefinition> messageDefinitions = new List<MessageDefinition>();

            for (int i = 0; i < lines.Length; i += 36)
            {
                /*MessageDef msgdef = new MessageDef(param1, param2);
                 * messageDefomotopms.add(msgdef);
                 */
                var param1 = lines[i + 0];
                var param2 = lines[i + 1];
                
                MessageDefinition msgdef = new MessageDefinition();
                messageDefinitions.Add(msgdef);
                

            }
           
            //string strResultJson = JsonConvert.DeserializeObject<MessageDefinition>();
            //File.WriteAllText(strReslutJson);
            

            return View();
        }
    }
}