using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Internship1.Controllers;
using Internship1.Interfaces;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

using Internship1.Service;
using Moq;
using NUnit.Framework;

namespace Internship1.Tests.Controllers
{
    [TestFixture]
    class MessageDefinitionControllerTest

    {
        private static string[] _csvLines = new string[]{ "Number,Title,componentType,Class,Level,ackMode,systemReactionMode,displayTitle.en,displayTitle.de,displayTitle.es,displayTitle.fr,displayTitle.it,displayTitle.ja,displayTitle.pt,displayTitle.ru,displayTitle.zh,displayDetails.en,displayDetails.de,displayDetails.es,displayDetails.fr,displayDetails.it,displayDetails.ja,displayDetails.pt,displayDetails.ru,displayDetails.zh,param1.description,param1.dataType,param1.unit,param1.uncertainty,param2.description,param2.dataType,param2.unit,param2.uncertainty,param3.description,param3.dataType,param3.unit,param3.uncertainty\n",
"1024,, Optima(Main instrument), App, Error, Manual, None, Dummy oxygen too high(en).,Dummy oxygen too high(de).,Dummy oxygen too high(es).,Dummy oxygen too high(fr).,Dummy oxygen too high(it).,Dummy oxygen too high(ja).,Dummy oxygen too high(pt).,Dummy oxygen too high(ru).,Dummy oxygen too high(zh).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (en).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (de).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (es).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (fr).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (it).,The oxygen level increased above 6%. The inlet temperature and the pump were shut down for safety reasons. (ja).,The oxygen level increased above 6%. The" };
        public static string[] CSV_TEXT
        {
            get { return _csvLines; }
            set { _csvLines = value; }
        }
        

        Mock<IReadInterface> mock; // Mock treba zbog menjanje ponasanje funkcije


        [Test]
        public void IndexReturnActionResult() 
        {
            //Asemble
            mock = new Mock<IReadInterface>();
            mock.Setup(x => x.readFile("")).Returns(CSV_TEXT);
            var cont = new MessageDefinitionController(mock.Object);
                    //Action
            ActionResult a = cont.Index("MessageDefinition.csv");
            //Asert
            Assert.IsNotNull(a);            
        }







    }
}
