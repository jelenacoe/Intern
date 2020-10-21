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
      
        public static string Export(List<ExportModel> model, string path)
        {

            string jsonIgnoreNullValues = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            System.IO.File.WriteAllText(path, jsonIgnoreNullValues);
            return jsonIgnoreNullValues;
        }


    }
}