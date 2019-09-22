using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace byndyusoft.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyArray()
        {
            var testArray = new int[0];
            Assert.AreEqual(0, Summator.GetSumOfMinElements(testArray));
        }

        [TestMethod]
        public void OneItemInArray()
        {
            var testArray = new int[1] { 10 };
            Assert.AreEqual(10, Summator.GetSumOfMinElements(testArray));
        }

        [TestMethod]
        public void TwoItemsInArray()
        {
            var testArray = new int[2] { 2, 2 };
            Assert.AreEqual(4, Summator.GetSumOfMinElements(testArray));
        }

        [TestMethod]
        public void SeveralItemsInArray()
        {
            var testArray = new int[5] { -10, 5, 0, 7, 167};
            Assert.AreEqual(-10, Summator.GetSumOfMinElements(testArray));
        }

        [TestMethod]
        public void TooManyItemsInArray()
        {
            var testArray = new int[1000000];
            var random = new Random();
            for (int i = 0; i < testArray.Length - 1; i++)
                testArray[i] = random.Next();            
            testArray[10] = -10;
            testArray[20] = -20;

            Assert.AreEqual(-30, Summator.GetSumOfMinElements(testArray));
        }
    }
}
