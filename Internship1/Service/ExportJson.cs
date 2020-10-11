using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Internship1.Models;


namespace Internship1.Service
{
    public class ExportJson 
    {
        public static string ExportJSON(List<MessageDefinition> list)
        {

            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(list);
            string json_pretty = JSON_PrettyPrinter.Process(serializedResult);
            

            System.IO.File.WriteAllText(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\new.json", json_pretty);
            return json_pretty;

        }
    }
}