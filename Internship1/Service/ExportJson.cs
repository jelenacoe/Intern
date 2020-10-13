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
        public static string ExportJSONEn(List<MessageDefinition> list)
        {

           /* string jsonIgnoreNullValues = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });*/

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);
            
            

            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\en-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONDe(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\de-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONEs(List<MessageDefinition> list)
        {


            string jsonIgnoreNullValues = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });


            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\es-new.json", jsonIgnoreNullValues);

            return jsonIgnoreNullValues;

        }
        public static string ExportJSONFr(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\fr-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONIt(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\it-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONJa(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\ja-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONPt(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\pt-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONRu(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\ru-new.json", serializedResult);

            return serializedResult;

        }
        public static string ExportJSONZh(List<MessageDefinition> list)
        {


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var serializedResult = System.Text.Json.JsonSerializer.Serialize(list, options);



            System.IO.File.WriteAllText(@"C:\Users\Korisnik\source\repos\Internship1\JsonLanguage\zh-new.json", serializedResult);

            return serializedResult;

        }
        
        public static string Export(List<ExportModel> model, string path)
        {

            string jsonIgnoreNullValues = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            //var serializedResult = System.Text.Json.JsonSerializer.SerializeObject(model);

            System.IO.File.WriteAllText(path, jsonIgnoreNullValues);
            return jsonIgnoreNullValues;
        }


    }
}