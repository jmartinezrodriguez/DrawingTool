using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using Moq;
using DrawingTool.Controllers;

namespace DrawingToolUnitTest
{
    [TestClass]
    public class BusinessUnitTest
    {
        Shape shape = new Shape();

        public BusinessUnitTest()
        {

        }


        [TestMethod]
        public void TestVerifyObjectCanva()
        {
            string[] data = new string[] { "C 400 300" };
            var canva = shape.DrawShape(data).canva;
            Assert.IsInstanceOfType(canva, typeof(Canva));
        }


        [TestMethod]
        public void TestCreateCanva()
        {
            string[] data = new string[] { "C 400 300" };
            var canva = shape.DrawShape(data).canva;
            Assert.IsNotNull(canva);
        }


        [TestMethod]
        public void TestCreateLine()
        {
            string[] data = new string[] { "C 400 300", "L 1 6 100 6" };
            var line = shape.DrawShape(data).line;
            Assert.IsNotNull(line);
        }

        [TestMethod]
        public void TestCreateRectangle()
        {
            string[] data = new string[] { "C 400 300", "L 1 6 100 6", "R 4 6 150 100" };
            var rectangle = shape.DrawShape(data).rectangle;
            Assert.IsNotNull(rectangle);
        }

        [TestMethod]
        public void TestCreateCanvaWithLine()
        {
            string[] data = new string[] { "C 400 300", "L 1 6 100 6" };
            var canva = shape.DrawShape(data).canva;
            var line = shape.DrawShape(data).line;

            Assert.IsNotNull(canva);
            Assert.IsNotNull(line);
        }

        [TestMethod]
        public void TestCreateCanvaWithRectangle()
        {
            string[] data = new string[] { "C 400 300", "R 4 6 150 100" };
            var canva = shape.DrawShape(data).canva;
            var rectangle = shape.DrawShape(data).rectangle;

            Assert.IsNotNull(canva);
            Assert.IsNotNull(rectangle);
        }

        [TestMethod]
        public void TestTypeElement()
        {
            string[] data = new string[] { "99 400 300" };
            var canva = shape.DrawShape(data).canva;
            Assert.IsNull(canva);
        }


        [TestMethod]
        public void TestFileEmty()
        {
            string[] data = new string[] { };
            var canva = shape.DrawShape(data).canva;
            var rectangle = shape.DrawShape(data).rectangle;
            Assert.IsNull(canva);
        }

        [TestMethod]
        public void TestCreatAllShapes()
        {
            string[] data = new string[] { "C 400 300", "L 1 6 100 6", "R 4 6 150 100" };
            var canva = shape.DrawShape(data).canva;
            var line = shape.DrawShape(data).line;
            var rectangle = shape.DrawShape(data).rectangle;

            Assert.IsNotNull(canva);
            Assert.IsNotNull(line);
            Assert.IsNotNull(rectangle);
        }

    }
}
