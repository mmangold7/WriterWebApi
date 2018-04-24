using System;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;

namespace WebApi.Tests
{
    [TestClass]
    public class WriteTest
    {
        [TestMethod]
        public void ReceivedHelloWorld()
        {
            //instantiate controller with required properties
            var writeController = new WriteController();
            writeController.Request = new HttpRequestMessage();
            writeController.Configuration = new HttpConfiguration();

            //call controller method
            var response = writeController.Get();

            //expected message
            string helloWorld = "Hello World!";

            //check if result matches expected
            Assert.AreEqual(helloWorld, response);
        }
    }
}
