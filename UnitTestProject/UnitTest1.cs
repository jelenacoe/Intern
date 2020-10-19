using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Internship1.Controllers;
using Internship1.Service;
using Internship1.Models;
using System.Web.Mvc;
using Azure.Storage.Blobs.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MessageDefinitionContorllerTest()
        {
            MessageDefinitionController controller = new MessageDefinitionController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
        [TestMethod]
        public void HomeContorllerTest()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;


        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Import() 
        {

            Import imp = new Import();
        
        }
        


    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void ExportServiceTest() { }
    
    }
}
