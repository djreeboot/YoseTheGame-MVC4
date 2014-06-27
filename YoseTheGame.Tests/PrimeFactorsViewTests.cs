using System;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class PrimeFactorsViewTests
    {
        private HtmlDocument _htmlDocument;

        [TestInitialize]
        public void ThisView()
        {
            _htmlDocument = new HtmlDocument();
            _htmlDocument.Load("..\\..\\..\\YoseTheGame\\Views\\PrimeFactors\\PrimeFactors.cshtml");
        }

        [TestMethod]
        public void HasElementWithTitleId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("title");
            Assert.IsNotNull(node);
        }

        [TestMethod]
        public void HasElementWithInvitationId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("invitation");
            Assert.IsNotNull(node);
        }

        [TestMethod]
        public void HasInputWithNumberId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("number");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "input");
        }

        [TestMethod]
        public void HasButtonWithGoId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("go");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "button");
        }

        [TestMethod]
        public void HasElementWithResultId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("result");
            Assert.IsNotNull(node);
        }

        [TestMethod]
        public void HasOrderedListWithResultsId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("results");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "ol");
        }

        [TestMethod]
        public void HasElementWithLastDecompisitionId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("last-decomposition");
            Assert.IsNotNull(node);
        }
    }
}
