using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumeral.App;

namespace RomanNumeral.Test
{
    [TestFixture]
    public class RomanNumeralTest
    {
        [Test]
        public void Converting_Roman_Numeral_I_to_Actual_Numbers()
        {
            //Arrange
            var Number = "1";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("I", result);

        }
        [Test]
        public void Converting_Roman_Numeral_V_to_Actual_Numbers()
        {
            //Arrange
            var Number = "5";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("v", result);

        }
        [Test]
        public void Converting_Roman_Numeral_IX_to_Actual_Numbers()
        {
            //Arrange
            var Number = "9";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("IX", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "12";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XVI_to_Actual_Numbers()
        {
            //Arrange
            var Number = "16";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XVI", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XXIX_to_Actual_Numbers()
        {
            //Arrange
            var Number = "29";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XXIX", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XLIV_to_Actual_Numbers()
        {
            //Arrange
            var Number = "44";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XLIV", result);

        }
        [Test]
        public void Converting_Roman_Numeral_xlv_to_Actual_Numbers()
        {
            //Arrange
            var Number = "45";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XLV", result);

        }
        [Test]
        public void Converting_Roman_Numeral_LXVIII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "68";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("LXVIII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_LXXXIII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "83";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("LXXXIII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XCVII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "97";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XCVII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_XCIX_to_Actual_Numbers()
        {
            //Arrange
            var Number = "99";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("XCIX", result);

        }
        [Test]
        public void Converting_Roman_Numeral_D_to_Actual_Numbers()
        {
            //Arrange
            var Number = "500";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("D", result);

        }
        [Test]
        public void Converting_Roman_Numeral_DI_to_Actual_Numbers()
        {
            //Arrange
            var Number = "501";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("DI", result);

        }
        [Test]
        public void Converting_Roman_Numeral_DCXLIX_to_Actual_Numbers()
        {
            //Arrange
            var Number = "649";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("DCXLIX", result);

        }
        [Test]
        public void Converting_Roman_Numeral_DCCXCVIII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "798";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("DCCXCVIII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_DCCCXCI_to_Actual_Numbers()
        {
            //Arrange
            var Number = "891";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("DCCCXCI", result);

        }
        [Test]
        public void Converting_Roman_Numeral_M_to_Actual_Numbers()
        {
            //Arrange
            var Number = "1000";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("M", result);

        }
        [Test]
        public void Converting_Roman_Numeral_MIV_to_Actual_Numbers()
        {
            //Arrange
            var Number = "1004";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("MIV", result);

        }
        [Test]
        public void Converting_Roman_Numeral_MVI_to_Actual_Numbers()
        {
            //Arrange
            var Number = "1006";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("MVI", result);

        }
        [Test]
        public void Converting_Roman_Numeral_MXXIII_to_Actual_Numbers()
        {
            //Arrange
            var Number = "1023";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("MXXIII", result);

        }
        [Test]
        public void Converting_Roman_Numeral_MMXIV_to_Actual_Numbers()
        {
            //Arrange
            var Number = "2014";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("MMXIV", result);

        }
        [Test]
        public void Converting_Roman_Numeral_MMMCMXCIX_to_Actual_Numbers()
        {
            //Arrange
            var Number = "3999";
            var romanNumeralConverter = new RomanNumeralConverter();

            //Act

            var result = romanNumeralConverter.Parse(Number);

            //Assert
            Assert.AreEqual("MMMCMXCIX", result);

        }
    }
}
