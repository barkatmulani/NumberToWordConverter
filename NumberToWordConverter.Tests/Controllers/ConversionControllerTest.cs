using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordConverter;
using NumberToWordConverter.Controllers;
using NumberToWordConverter.Models;

namespace NumberToWordConverter.Tests.Controllers
{
    [TestClass]
    public class ConversionControllerTest
    {
        /********** Test 1 = ONE DOLLAR **********/
        [TestMethod]
        public void Get_01()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Test", result.Name);
            Assert.AreEqual("ONE DOLLAR", result.Words);
        }

        /********** Test 2.01 = TWO DOLLARS AND ONE CENT **********/
        [TestMethod]
        public void Get_02()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 2.01);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TWO DOLLARS AND ONE CENT", result.Words);
        }

        /********** Test 10.11 = TEN DOLLARS AND ELEVEN CENTS **********/
        [TestMethod]
        public void Get_03()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 10.11);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TEN DOLLARS AND ELEVEN CENTS", result.Words);
        }

        /********** Test 25.50 = TWENTY-FIVE DOLLARS AND FIFTY CENTS **********/
        [TestMethod]
        public void Get_04()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 25.50);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TWENTY-FIVE DOLLARS AND FIFTY CENTS", result.Words);
        }

        /********** Test 100 = ONE HUNDRED DOLLARS **********/
        [TestMethod]
        public void Get_05()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 100);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED DOLLARS", result.Words);
        }

        /********** Test 100.99 = ONE HUNDRED DOLLARS AND NINETY-NINE CENTS **********/
        [TestMethod]
        public void Get_06()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 100.99);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED DOLLARS AND NINETY-NINE CENTS", result.Words);
        }

        /********** Test 1001 = ONE THOUSAND AND ONE DOLLARS **********/
        [TestMethod]
        public void Get_07()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1001);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE THOUSAND AND ONE DOLLARS", result.Words);
        }

        /********** Test 1010 = ONE THOUSAND AND TEN DOLLARS **********/
        [TestMethod]
        public void Get_08()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1010);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE THOUSAND AND TEN DOLLARS", result.Words);
        }

        /********** Test 1203 = ONE THOUSAND TWO HUNDRED AND THREE DOLLARS **********/
        [TestMethod]
        public void Get_09()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1203);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE THOUSAND TWO HUNDRED AND THREE DOLLARS", result.Words);
        }

        /********** Test 1234.56 = ONE THOUSAND TWO HUNDRED AND THIRTY-FOUR DOLLARS AND FIFTY-SIX CENTS **********/
        [TestMethod]
        public void Get_10()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1234.56);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE THOUSAND TWO HUNDRED AND THIRTY-FOUR DOLLARS AND FIFTY-SIX CENTS", result.Words);
        }

        /********** Test 95009.88 = NINETY-FIVE THOUSAND AND NINE DOLLARS AND EIGHTY-EIGHT CENTS **********/
        [TestMethod]
        public void Get_11()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 95009.88);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("NINETY-FIVE THOUSAND AND NINE DOLLARS AND EIGHTY-EIGHT CENTS", result.Words);
        }

        /********** Test 100001.01 = ONE HUNDRED THOUSAND AND ONE DOLLARS AND ONE CENT **********/
        [TestMethod]
        public void Get_12()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 100001.01);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED  THOUSAND AND ONE DOLLARS AND ONE CENT", result.Words);
        }

        /********** Test 101001.01 = ONE MILLION TEN THOUSAND AND ONE DOLLARS AND ONE CENT **********/
        [TestMethod]
        public void Get_13()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 1010001.01);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE MILLION TEN THOUSAND AND ONE DOLLARS AND ONE CENT", result.Words);
        }

        /********** Test 100010001.01 = ONE HUNDRED MILLION TEN THOUSAND AND ONE DOLLARS AND ONE CENT **********/
        [TestMethod]
        public void Get_14()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 100010001.01);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ONE HUNDRED  MILLION TEN THOUSAND AND ONE DOLLARS AND ONE CENT", result.Words);
        }

        /********** Test 999999999.99 = NINE HUNDRED AND NINETY-NINE MILLION NINE HUNDRED AND NINETY-NINE THOUSAND NINE HUNDRED AND NINETY-NINE DOLLARS AND NINETY-NINE CENTS **********/
        [TestMethod]
        public void Get_15()
        {
            // Arrange
            ConversionController controller = new ConversionController();

            // Act
            NameAndMoney result = controller.Get("Test", 999999999.99);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("NINE HUNDRED AND NINETY-NINE MILLION NINE HUNDRED AND NINETY-NINE THOUSAND NINE HUNDRED AND NINETY-NINE DOLLARS AND NINETY-NINE CENTS", result.Words);
        }

    }
}
