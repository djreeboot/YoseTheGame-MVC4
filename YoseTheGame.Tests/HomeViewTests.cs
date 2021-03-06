﻿using System;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class HomeViewTests
    {
        private HtmlDocument _htmlDocument;

        [TestInitialize]
        public void ThisView()
        {
            _htmlDocument = new HtmlDocument();
            _htmlDocument.Load("..\\..\\..\\YoseTheGame\\Views\\Home\\Home.cshtml");
        }

        [TestMethod]
        public void HasFirstLevelTitleContainingHelloYose()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectSingleNode("//body//h1");
            Assert.IsTrue(node.InnerText == "Hello Yose");
        }

        [TestMethod]
        public void HasAnchorWithRepositoryLinkId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("repository-link");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "a");
        }

        [TestMethod]
        public void HasAnchorWithContactMeLinkId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("contact-me-link");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "a");
        }

        [TestMethod]
        public void HasAnchorWithPingChallengeLinkId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("ping-challenge-link");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "a");
        }

        [TestMethod]
        public void HasAnchorWithPrimeFactorsDecompositionLinkId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("prime-factors-decomposition-link");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "a");
        }

        [TestMethod]
        public void HasAnchorWithMinesweeperLinkId()
        {
            HtmlNode node = _htmlDocument.GetElementbyId("minesweeper-link");
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Name.ToLower() == "a");
        }
    }
}
