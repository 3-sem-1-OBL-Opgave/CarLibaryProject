using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibaryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibaryProject.Tests
{
    [TestClass()]
    public class CarTests
    {
        // Accepted Cars
        private Car goodCar =       new Car { Id = 1, Model = "718 Boxster",    Price = 1099900,    LicensePlate = "XA55018" };

        // Fail Cars
        private Car FailModelCar =  new Car { Id = 3, Model = "",               Price = 200000,     LicensePlate = "AA12345" };
        private Car FailPriceCar =  new Car { Id = 4, Model = "Passat",         Price = -2,         LicensePlate = "AA12345" };
        private Car FailLPCar =     new Car { Id = 5, Model = "Passat",         Price = 200000,     LicensePlate = "" };

        [TestMethod()]
        public void ModelValidatorTest()
        {
            goodCar.ModelValidator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FailModelCar.ModelValidator());
        }

        [TestMethod()]
        public void PriceValidatorTest()
        {
            goodCar.PriceValidator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FailPriceCar.PriceValidator());
        }

        [TestMethod()]
        public void LPValidatorTest()
        {
            goodCar.LPValidator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FailLPCar.LPValidator());
        }
    }
}