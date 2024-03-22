using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestRouteOptimizer.Controllers;
using System;
using System.Web.Mvc;

namespace ShortestRouteOptimizerUnitTest
{
    [TestClass]
    public class ShortestPathControllerTest
    {
        [TestMethod]
        public void TestViewPath()
        {
            // Arrange
            ShortestPathController controller = new ShortestPathController();

            // Act
            ViewResult result = controller.Path() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestViewResult()
        {
            // Arrange
            ShortestPathController controller = new ShortestPathController();

            // Act
            ViewResult result = controller.Result() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }
    }
}
