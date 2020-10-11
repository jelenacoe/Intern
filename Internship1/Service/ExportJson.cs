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
using System.Text.Json;
using Internship1.Models;


namespace Internship1.Service
{
    public class ExportJson 
    {
        public static string ExportJSON(List<MessageDefinition> list)
        {

            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);
            
            

            System.IO.File.WriteAllText(@"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\new.json", serializedResult);
            return serializedResult;

        }
    }
}