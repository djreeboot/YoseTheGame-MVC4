using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Worlds.PrimeFactors;

namespace YoseTheGame.Tests.Worlds
{
    [TestClass]
    public class RomanNumberTests
    {
        [TestMethod]
        public void CanConvert2ToRoman()
        {
            string value = RomanNumber.ToRoman(2);
            Assert.AreEqual("II", value);
        }

        [TestMethod]
        public void CanConvertIIFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("II", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(2, value);
        }

        [TestMethod]
        public void CanConvert4ToRoman()
        {
            string value = RomanNumber.ToRoman(4);
            Assert.AreEqual("IV", value);
        }

        [TestMethod]
        public void CanConvertIVFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("IV", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(4, value);
        }

        [TestMethod]
        public void CanConvert9ToRoman()
        {
            string value = RomanNumber.ToRoman(9);
            Assert.AreEqual("IX", value);
        }

        [TestMethod]
        public void CanConvertIXFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("IX", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(9, value);
        }

        [TestMethod]
        public void CanConvert13ToRoman()
        {
            string value = RomanNumber.ToRoman(13);
            Assert.AreEqual("XIII", value);
        }

        [TestMethod]
        public void CanConvertXIIIFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("XIII", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(13, value);
        }

        [TestMethod]
        public void CanConvert14ToRoman()
        {
            string value = RomanNumber.ToRoman(14);
            Assert.AreEqual("XIV", value);
        }

        [TestMethod]
        public void CanConvertXIVFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("XIV", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(14, value);
        }

        [TestMethod]
        public void CanConvert44ToRoman()
        {
            string value = RomanNumber.ToRoman(44);
            Assert.AreEqual("XLIV", value);
        }

        [TestMethod]
        public void CanConvertXLIVFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("XLIV", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(44, value);
        }

        [TestMethod]
        public void CanConvert144ToRoman()
        {
            string value = RomanNumber.ToRoman(144);
            Assert.AreEqual("CXLIV", value);
        }

        [TestMethod]
        public void CanConvertCXLIVFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("CXLIV", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(144, value);
        }

        [TestMethod]
        public void CanConvert143ToRoman()
        {
            string value = RomanNumber.ToRoman(143);
            Assert.AreEqual("CXLIII", value);
        }

        [TestMethod]
        public void CanConvertCXLIIIFromRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("CXLIII", out value);
            Assert.IsTrue(result);
            Assert.AreEqual(143, value);
        }

        [TestMethod]
        public void CanHandleFalseRoman()
        {
            int value = 0;
            bool result = RomanNumber.TryParse("FF", out value);
            Assert.IsFalse(result);
        }
    }
}
