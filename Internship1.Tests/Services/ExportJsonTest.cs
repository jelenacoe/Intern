using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Internship1.Models;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Internship1.Tests.Services
{
    [TestFixture]
    public class ExportJsonTest
    {
        private static string[] _csvLines = new string[]{ "Number,Title,componentType,Class,Level,ackMode,systemReactionMode,displayTitle.en,displayTitle.de,displayTitle.es,displayTitle.fr,displayTitle.it,displayTitle.ja,displayTitle.pt,displayTitle.ru,displayTitle.zh,displayDetails.en,displayDetails.de,displayDetails.es,displayDetails.fr,displayDetails.it,displayDetails.ja,displayDetails.pt,displayDetails.ru,displayDetails.zh,param1.description,param1.dataType,param1.unit,param1.uncertainty,param2.description,param2.dataType,param2.unit,param2.uncertainty,param3.description,param3.dataType,param3.unit,param3.uncertainty\n",
        "1024,, Optima(Main instrument), App, Error, Manual, None, Dummy oxygen too high(en).,Dummy oxygen too high(de).,Dummy oxygen too high(es).,Dummy oxygen too high(fr).,Dummy oxygen too high(it).,Dummy oxygen too high(ja).,Dummy oxygen too high(pt).,Dummy oxygen too high(ru).,Dummy oxygen too high(zh).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (de).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (es).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (fr).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (it).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (ja).,The oxygen level increased above 6%. The" };
        public static string[] CSV_TEXT
        {
            get { return _csvLines; }
            set { _csvLines = value; }
        }
        [Test]
        public void ExportJsonEnSucess()
        {
            // Act
            List<ExportModel> result = Internship1.Service.ImportService.ImportFileEn(CSV_TEXT);

            // Assert
            Assert.IsNotNull(result); // Check that we are getting something
            Assert.IsNotNull(result[0]); // Check we are getting one type of Models.ExportModel

            string json = Internship1.Service.ExportJson.Export(result, "");

            Assert.That(json.Equals("[\r\n  {\r\n    \"ID\": 1024,\r\n    \"TITLE\": \" Dummy oxygen too high(en).\",\r\n    \"DETAILS\": \"The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en).\"\r\n  }\r\n]"));
           

        }
        [Test]
        public void ExportJsonEnFail()
        {

            List<ExportModel> model = new List<ExportModel>();
            
               
           model.Add(new ExportModel{ ID =1,TITLE="something",DETAILS="false"});
            


            string json = Internship1.Service.ExportJson.Export(model, "");

            Assert.That(json.Equals("[\r\n  {\r\n    \"ID\": 1024,\r\n    \"TITLE\": \" Dummy oxygen too high(en).\",\r\n    \"DETAILS\": \"The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en).\"\r\n  }\r\n]"),Is.False);


        }
    }
}
