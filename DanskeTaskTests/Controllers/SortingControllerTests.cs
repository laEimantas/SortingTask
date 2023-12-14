using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanskeTask.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using static System.Net.WebRequestMethods;
using System.Net;
using DanskeTask.Interfaces;
using DanskeTask.Mocks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace DanskeTask.Controllers.Tests
{
    [TestClass()]
    public class SortingControllerTests
    {
        [TestMethod()]
        public void PostSmallNumberSetTest()
        {
            //Arrange
            MockFileHandlerOperations fileHandlerOperations= new MockFileHandlerOperations();   

            SortingController controller = new SortingController(fileHandlerOperations);
            int[] numbers = { 1, 2, 3 };

            //Act
            var result = controller.Post(numbers);
            var okRespone = result as OkObjectResult;

            //Assert
            Assert.AreEqual(okRespone.StatusCode, 200);
        }

        [TestMethod()]
        public void PostNotEnoughDataTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            int[] numbers = { 1 };
            var result = controller.Post(numbers);
            var badRequestResponse = result as BadRequestObjectResult;

            Assert.AreEqual(badRequestResponse.StatusCode, 400);
        }

        [TestMethod()]
        public void PostLargeDataSetTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            int[] numbers = Enumerable.Range(0, 99999999).ToArray();

            var result = controller.Post(numbers);
            var acceptedRequestResponse = result as AcceptedResult;

            Assert.AreEqual(acceptedRequestResponse.StatusCode, 202);
        }


        [TestMethod()]
        public void DeleteTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Delete();
            var undefinedResponse  = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }

        [TestMethod()]
        public void PutTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Put();
            var undefinedResponse = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }

        [TestMethod()]
        public void PatchTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Patch();
            var undefinedResponse = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }

        [TestMethod()]
        public void OptionsTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Options();
            var undefinedResponse = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }

        [TestMethod()]
        public void GetTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Get();
            var undefinedResponse = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }
    }
}