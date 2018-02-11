using System;
using FurnitureManufacturer.Models;
using FurnitureManufacturer.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FurnitureManifacturer.Tests.Models
{
    [TestClass]
    public class CompanyTests
    {
        // Constructor tests

        [TestMethod]
        public void CompanyConstructorShouldCreateCompanyWithSameNameAsGiven()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);

            Assert.AreEqual("Furniture Company EOOD", companyToTest.Name);       
        }

        [TestMethod]
        public void CompanyConstructorShouldCreateCompanyWithSameRegistrationNumberAsGiven()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);

            Assert.AreEqual("1234567890", companyToTest.RegistrationNumber);            
        }

        [TestMethod]
        public void CompanyConstructorShouldCreateCompanyWithEmptyFurnitureList()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);

            Assert.AreEqual(0, companyToTest.Furnitures.Count);
        }

        // Add method tests

        [TestMethod]
        public void AddMethodShouldAddFurnitureToCompanyWhenParametersAreValid()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            IMock<IFurniture> furnitureStub = new Mock<IFurniture>();
            ICompany companyToTest = new Company(companyName, registrationNumber);

            companyToTest.Add(furnitureStub.Object);

            Assert.IsTrue(companyToTest.Furnitures.Count == 1 && companyToTest.Furnitures.Contains(furnitureStub.Object));
        }

        [TestMethod]
        public void AddMethodShouldThrowAnExceptionWhenNullParameterspassed()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            var companyToTest = new Company(companyName, registrationNumber);

            Assert.ThrowsException<ArgumentNullException>(() => companyToTest.Add(null));
        }

        // Find method tests
        [TestMethod]
        public void FindMethodShouldReturnTheSearchedFurniture()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);
            string furnitureModel = "Fancy Chair";
            Mock<IFurniture> furnitureStub = new Mock<IFurniture>();
            furnitureStub.SetupGet(x => x.Model).Returns(furnitureModel);
            companyToTest.Furnitures.Add(furnitureStub.Object);

            IFurniture result = companyToTest.Find(furnitureModel);

            Assert.AreSame(furnitureStub.Object, result);
        }

        [TestMethod]
        public void FindMethodThrowsExceptionWhenNullParameterPassed()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);

            Assert.ThrowsException<ArgumentNullException>(() => companyToTest.Find(null));
        }

        // Catalog methods tests

        [TestMethod]
        public void CatalogMethodShouldReturnProperMessageWhenGivenValidParameters()
        {
            string companyName = "Furniture Company EOOD";
            string registrationNumber = "1234567890";
            ICompany companyToTest = new Company(companyName, registrationNumber);

            Assert.AreEqual($"{companyName} - {registrationNumber} - no furnitures", companyToTest.Catalog());
        }
    }
}