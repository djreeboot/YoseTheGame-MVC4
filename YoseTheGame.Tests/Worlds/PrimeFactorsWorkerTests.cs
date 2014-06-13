using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Worlds.PrimeFactors;

namespace YoseTheGame.Tests.Worlds
{
    [TestClass]
    public class PrimeFactorsWorkerTests
    {
        [TestMethod]
        public void CanDecompose2()
        {
            Response response = PrimeFactorsWorker.Decompose("2");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2 });
        }

        [TestMethod]
        public void CanDecompose3()
        {
            Response response = PrimeFactorsWorker.Decompose("3");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 3 });
        }

        [TestMethod]
        public void CanDecompose4()
        {
            Response response = PrimeFactorsWorker.Decompose("4");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2, 2 });
        }

        [TestMethod]
        public void CanDecompose36()
        {
            Response response = PrimeFactorsWorker.Decompose("36");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2, 2, 3, 3 });
        }

        [TestMethod]
        public void CanHandleString()
        {
            Response response = PrimeFactorsWorker.Decompose("batman");
            Assert.AreSame(response.GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)response).number.GetType(), typeof(string));
            Assert.AreEqual(((ErrorResponse)response).error, "not a number");
        }

        [TestMethod]
        public void CanHandleBigNumber()
        {
            Response response = PrimeFactorsWorker.Decompose("1000001");
            Assert.AreSame(response.GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)response).number.GetType(), typeof(int));
            Assert.AreEqual(((ErrorResponse)response).error, "too big number (>1e6)");
        }

        [TestMethod]
        public void CanHandleMultipleResponses()
        {
            List<Response> responses = PrimeFactorsWorker.Decompose(new string[] { "2", "hello", "1000001" });
            Assert.IsTrue(responses.Count == 3);

            Assert.AreSame(responses[0].GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)responses[0]).decomposition, new List<int> { 2 });

            Assert.AreSame(responses[1].GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)responses[1]).number.GetType(), typeof(string));
            Assert.AreEqual(((ErrorResponse)responses[1]).error, "not a number");

            Assert.AreSame(responses[2].GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)responses[2]).number.GetType(), typeof(int));
            Assert.AreEqual(((ErrorResponse)responses[2]).error, "too big number (>1e6)");

        }
    }
}
