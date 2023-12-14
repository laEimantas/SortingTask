using DanskeTask.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanskeTask.Interfaces;
using DanskeTask.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace DanskeTask.Controllers.Tests
{
    [TestClass()]
    public class FileDataControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            FileDataController fileDataController = new FileDataController(new MockFileHandlerOperations());

            var result = fileDataController.Get();

            var okRespone = result as OkObjectResult;

            Assert.AreEqual(okRespone.StatusCode, 200);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Delete();
            var undefinedResponse = result as ObjectResult;

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
        public void PostTest()
        {
            SortingController controller = new SortingController(new MockFileHandlerOperations());

            var result = controller.Get();
            var undefinedResponse = result as ObjectResult;

            Assert.AreEqual(undefinedResponse.StatusCode, 405);
        }
    }
}