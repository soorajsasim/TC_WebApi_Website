using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDetails.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails.Common.Tests
{
    [TestClass()]
    public class ConversionTests
    {
        /// <summary>
        /// This test method validates the logic for finding out whole numbers
        /// </summary>
        [TestMethod()]
        public void DoubleToDollarTest()
        {
            // arrange  
            int expected = 100;
            // act  
            int result = Conversion.DoubleToDollar(100.15);
            // assert   
            Assert.AreEqual(expected, result);

        }
        /// <summary>
        /// This test method validates the logic for finding out decimal values
        /// </summary>        
        [TestMethod()]
        public void DoubleToCentsTest()
        {
            // arrange 
            int expected = 45;
            // act 
            int result = Conversion.DoubleToCents(100.45);
            // assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        ///  This test method validates the logic for adding 'and'
        ///  The if condition involving words != "" will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_and_Test()
        {
            // arrange 
            string expected = "three hundred and six";
            // act
            string actual = Conversion.NumberToWords(306);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// This test method validates the logic for identiying 0
        /// The if condition involving zero array will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_zero_Test()
        {
            // arrange 
            string expected = "zero";
            // act
            string actual = Conversion.NumberToWords(0);
            // assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// This test method validates the logic for identiying numbers between 1 and 19
        /// The if condition involving unitsMap array will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_unitsMap_Test()
        {
            // arrange 
            string expected = "one";
            // act
            string actual = Conversion.NumberToWords(1);
            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// This test method validates the logic for identiying numbers such as 10, 20, 30 till 90
        /// The if condition involving tensMap array will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_tensMap_Test()
        {
            // arrange 
            string expected = "thirty";
            // act
            string actual = Conversion.NumberToWords(30);
            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// This test method validates the logic for identiying hundreds
        /// The if condition involving logic for hundred will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_hundred_Test()
        {
            // arrange 
            string expected = "five hundred ";
            // act
            string actual = Conversion.NumberToWords(500);
            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// This test method validates the logic for identiying thousands
        ///  The if condition involving logic for thousand will be tested
        /// </summary>
        [TestMethod()]
        public void NumberToWords_thousand_Test()
        {
            // arrange 
            string expected = "seven thousand ";
            // act
            string actual = Conversion.NumberToWords(7000);
            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///  This test method validates the logic for identiying millions
        ///  The if condition involving logic for million will be tested
        /// </summary>

        [TestMethod()]
        public void NumberToWords_Million_Test()
        {
            // arrange 
            string expected = "five million ";
            // act
            string actual = Conversion.NumberToWords(5000000);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}