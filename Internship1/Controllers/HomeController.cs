using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Internship1.Models;

namespace Internship1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*var csv_file_path = @"C:\Users\Korisnik\Desktop\MessageDefinition.csv";
            string text = System.IO.File.ReadAllText(csv_file_path);

            var lines = text.Split(',');

            List<MessageDefinition> messageDefinitions = new List<MessageDefinition>();


            for (int i = 0; i < lines.Length; i += 36)
            {
                /*MessageDef msgdef = new MessageDef(param1, param2);
                 * messageDefomotopms.add(msgdef);
                 */

               /* var param1 = lines[i + 0];
                var param2 = lines[i + 1];
                var param3 = lines[i + 2];*/


                //MessageDefinition msgdef = new MessageDefinition();

            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}