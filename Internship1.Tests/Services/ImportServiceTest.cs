using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Internship1.Service;
using System.IO;
using Internship1.Models;
using System.Web;
using NUnit.Framework;

namespace Internship1.Tests.Service
{

    [TestFixture]
    public class ImportServiceTest
    {


        private static string[] _csvLines = new string[]{ "Number,Title,componentType,Class,Level,ackMode,systemReactionMode,displayTitle.en,displayTitle.de,displayTitle.es,displayTitle.fr,displayTitle.it,displayTitle.ja,displayTitle.pt,displayTitle.ru,displayTitle.zh,displayDetails.en,displayDetails.de,displayDetails.es,displayDetails.fr,displayDetails.it,displayDetails.ja,displayDetails.pt,displayDetails.ru,displayDetails.zh,param1.description,param1.dataType,param1.unit,param1.uncertainty,param2.description,param2.dataType,param2.unit,param2.uncertainty,param3.description,param3.dataType,param3.unit,param3.uncertainty\n",
        "1024,, Optima(Main instrument), App, Error, Manual, None, Dummy oxygen too high(en).,Dummy oxygen too high(de).,Dummy oxygen too high(es).,Dummy oxygen too high(fr).,Dummy oxygen too high(it).,Dummy oxygen too high(ja).,Dummy oxygen too high(pt).,Dummy oxygen too high(ru).,Dummy oxygen too high(zh).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (de).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (es).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (fr).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (it).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (ja).,The oxygen level increased above 6%. The" };
        public static string[] CSV_TEXT
        {
            get { return _csvLines; }
            set { _csvLines = value; }
        }

        [Test]
        public void ImportFileEnTestSucess()
        {

            // Act
            List<ExportModel> result = Internship1.Service.ImportService.ImportFileEn(CSV_TEXT);

            // Assert
            Assert.IsNotNull(result); // Check that we are getting something
            Assert.IsNotNull(result[0]); // Check we are getting one type of Models.ExportModel

            // Check that Models.ExportModel is adequete to CSV_TEXT
            Assert.That(result[0].DETAILS.Equals("The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en)."));
            Assert.That(result[0].ID.Equals(1024));
            Assert.That(result[0].TITLE.Equals(" Dummy oxygen too high(en)."));
           
        }

        [Test]
        public void ImportFileDeTestSucess()
        {

            // Act
            List<ExportModel> result = Internship1.Service.ImportService.ImportFileDe(CSV_TEXT);

            // Assert
            Assert.IsNotNull(result); // Check that we are getting something
            Assert.IsNotNull(result[0]); // Check we are getting one type of Models.ExportModel

            Assert.That(result[0].DETAILS.Equals("The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (de)."));
            Assert.That(result[0].ID.Equals(1024));
            Assert.That(result[0].TITLE.Equals("Dummy oxygen too high(de)."));
        }

        [Test]
        public void ImportFileFrFailTestSucess()
        {

            // Act
            List<ExportModel> result = Internship1.Service.ImportService.ImportFileFr(CSV_TEXT);

            // Assert
            Assert.IsNotNull(result); // Check that we are getting something
            Assert.IsNotNull(result[0]); // Check we are getting one type of Models.ExportModel

            // Check that Models.ExportModel is adequete to CSV_TEXT
            Assert.That(result[0].DETAILS.Equals("The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en)."), Is.False);
            Assert.That(result[0].ID.Equals(1024));
            Assert.That(result[0].TITLE.Equals(" Dummy oxygen too high(en)."),Is.False);

        }



        [Test]
        public void ImportFileEnTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileEn(new string[]{"",""})
                );
            

        }
        [Test]
        public void ImportFileDeTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileDe(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileEsTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileEs(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileFrTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileFr(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileItTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileIt(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileJaTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileJa(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFilePtTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFilePt(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileRuTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileRu(new string[] { "", "" })
                );


        }
        [Test]
        public void ImportFileZhTestExeption()
        {

            // Assert
            Assert.Throws<FormatException>(
                () => Internship1.Service.ImportService.ImportFileZh(new string[] { "", "" })
                );


        }




    }
}
