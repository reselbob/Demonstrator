using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reselbob.Demonstrator.Tests
{
    [TestClass]
    public class DemoTests
    {
        /// <summary>
        /// Hardcoded test that processes an array of
        /// numbers in which the numbers are in ascending
        /// sequence
        /// </summary>
        [TestMethod]
        public void DiffHardCodedArrayOneTest()
        {
            int[] numbers =
            {
                3,
                7,
                8,
                11
            };
            var rtn = Differentiator.GreatestDifference(numbers);
            Assert.AreEqual(8,rtn);

        }

        /// <summary>
        /// Hardcoded test that processes an array of numbers
        /// in which all numbers in the array identical and 
        /// positive
        /// </summary>
        [TestMethod]
        public void DiffHardCodedArrayTwoTest()
        {
            int[] numbers =
            {
                2,
                2,
                2,
                2
            };
            var rtn = Differentiator.GreatestDifference(numbers);
            Assert.AreEqual(0, rtn);
        }

        /// <summary>
        /// Hardcoded test that processes an array of
        /// numbers in which the numbers are in random
        /// sequence
        /// </summary>
        [TestMethod]
        public void DiffHardCodedArrayThreeTest()
        {
            int[] numbers =
            {
                2,13,5,9
            };
            var rtn = Differentiator.GreatestDifference(numbers);
            Assert.AreEqual(11, rtn);
        }

        /// <summary>
        /// Hardcoded test that processes an array of
        /// numbers in which the numbers are in random
        /// sequence, and the array includes some
        /// negative numbers
        /// </summary>
        [TestMethod]
        public void DiffHardCodedArrayFourTest()
        {
            int[] numbers =
            {
                12,-1,5,9,100,47,-8,11
            };
            var rtn = Differentiator.GreatestDifference(numbers);
            Assert.AreEqual(101, rtn);
        }


        /// <summary>
        /// Hardcoded test that processes an array of
        /// numbers in which the numbers are in random
        /// sequence, and the array includes some
        /// negative numbers
        /// </summary>
        [TestMethod]
        public void DiffHardCodedArrayFiveTest()
        {
            int[] numbers =
            {
                -12,-1,-5,-9,-88,-47,-8,-11
            };
            var rtn = Differentiator.GreatestDifference(numbers);
            Assert.AreEqual(80, rtn);
        }

        /// <summary>
        /// This test does not have enough elements in the array
        /// so the GreatestDifference() method should throw an
        /// argument exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DiffHardCodedArrayExceptionTest()
        {
            int[] numbers =
            {
                2
            };
            var rtn = Differentiator.GreatestDifference(numbers);
        }

    }
}