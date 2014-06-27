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
            object response = PrimeFactorsWorker.Decompose("2");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2 });
        }

        [TestMethod]
        public void CanDecompose3()
        {
            object response = PrimeFactorsWorker.Decompose("3");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 3 });
        }

        [TestMethod]
        public void CanDecompose4()
        {
            object response = PrimeFactorsWorker.Decompose("4");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2, 2 });
        }

        [TestMethod]
        public void CanDecompose36()
        {
            object response = PrimeFactorsWorker.Decompose("36");
            Assert.AreSame(response.GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)response).decomposition, new List<int> { 2, 2, 3, 3 });
        }

        [TestMethod]
        public void CanHandleString()
        {
            object response = PrimeFactorsWorker.Decompose("batman");
            Assert.AreSame(response.GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)response).number.GetType(), typeof(string));
            Assert.AreEqual(((ErrorResponse)response).error, "not a number");
        }

        [TestMethod]
        public void CanHandleBigNumber()
        {
            object response = PrimeFactorsWorker.Decompose("1000001");
            Assert.AreSame(response.GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)response).number.GetType(), typeof(int));
            Assert.AreEqual(((ErrorResponse)response).error, "too big number (>1e6)");
        }

        [TestMethod]
        public void CanHandleNegativeNumber()
        {
            object response = PrimeFactorsWorker.Decompose("-1");
            Assert.AreSame(response.GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)response).number.GetType(), typeof(int));
            Assert.AreEqual(((ErrorResponse)response).error, "-1 is not an integer > 1");
        }

        [TestMethod]
        public void CanHandleMultipleResponses()
        {
            object responses = PrimeFactorsWorker.Decompose(new string[] { "2", "hello", "1000001" });
            Assert.AreSame(responses.GetType(), typeof(List<Response>));
            Assert.IsTrue(((List<Response>)responses).Count == 3);

            Assert.AreSame(((List<Response>)responses)[0].GetType(), typeof(SuccessResponse));
            CollectionAssert.AreEqual(((SuccessResponse)((List<Response>)responses)[0]).decomposition, new List<int> { 2 });

            Assert.AreSame(((List<Response>)responses)[1].GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)((List<Response>)responses)[1]).number.GetType(), typeof(string));
            Assert.AreEqual(((ErrorResponse)((List<Response>)responses)[1]).error, "not a number");

            Assert.AreSame(((List<Response>)responses)[2].GetType(), typeof(ErrorResponse));
            Assert.AreSame(((ErrorResponse)((List<Response>)responses)[2]).number.GetType(), typeof(int));
            Assert.AreEqual(((ErrorResponse)((List<Response>)responses)[2]).error, "too big number (>1e6)");

        }

        [TestMethod]
        public void CanDecomposeRoman()
        {
            object response = PrimeFactorsWorker.Decompose("IV");
            Assert.AreSame(response.GetType(), typeof(RomanResponse));
            CollectionAssert.AreEqual(((RomanResponse)response).decomposition, new List<string> { "II", "II" });
        }
    }
}
