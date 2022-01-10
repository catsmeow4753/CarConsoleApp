using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarConsoleApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1GetCar()
        {
            // Arrange
            CarCatalogDictionary catalog = new CarCatalogDictionary();

            string regNo = "XX12345";
            Car car1 = new Car() {RegNo = regNo, Model = "BMW", Hk = 150};
            
            // Act
            catalog.AddCar(new Car() { RegNo = regNo, Model = "BMW", Hk = 150 });
            Car car2 = catalog.GetCar(regNo);

            // Assert
            Assert.AreEqual(car2.RegNo, car1.RegNo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2ArgumentException()
        {
            // Arrange
            CarCatalogDictionary catalog = new CarCatalogDictionary();
            Car car1 = new Car("123", "BMW", 100);

            // Act
            catalog.AddCar(car1);

            // Assert
        }
    }
}