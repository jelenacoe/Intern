using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Internship1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Contollers
{
    [TestClass]
    class MessageDefinitionControllerTest

    {


        [TestMethod]
        public void IndexReturnActionResult() 
        {
            //Asemble
            MessageDefinitionController controller = new MessageDefinitionController();
            //Action
            ActionResult a = controller.Index("path");
            //Asert
            Assert.IsNotNull(a);
            
        }
    }
}
