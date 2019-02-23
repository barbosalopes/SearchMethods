using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private int Value { get; set; }
        private int ExpectedValue { get; set; }
        private int Res { get; set; }
        private int MidleItem { get; set; }
        private int FirstItem { get; set; }
        private int LastItem { get; set; }
        private int NonExistentItem { get; set; }
        private int ExistentItem { get; set; }


        // Make readonly
        private int[] Arr;

        [TestInitialize]
        public void AssemblyInit()
        {
            Arr = new int[]{ 12, 13, 14, 20, 25, 30, 33, 50, 57, 99 };
            FirstItem = 12;
            LastItem = 99;
            MidleItem = 25;
            NonExistentItem = 34;
            ExistentItem = 14;
        }

        [TestMethod]
        public void TestSimple()
        {
            Value = ExpectedValue = 14;
            Res = BinarySearch.Search(Arr, Value);
            Assert.AreEqual(ExpectedValue, Res);
        }

        [TestMethod]
        public void TestOnStart()
        {
            Value = ExpectedValue = FirstItem;
            Res = BinarySearch.Search(Arr, Value);
            Assert.AreEqual(ExpectedValue, Res);
        }

        [TestMethod]
        public void TestOnEnding()
        {
            Value = ExpectedValue = LastItem;
            Res = BinarySearch.Search(Arr, Value);
            Assert.AreEqual(ExpectedValue, Res);
        }

        [TestMethod]
        public void TestNonExistentObject()
        {
            Value = NonExistentItem;
            Res = BinarySearch.Search(Arr, Value);
            Assert.IsNull(Res);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            Value = NonExistentItem;
            int[] arr = new int[0];
            Res = BinarySearch.Search(arr, Value);
            Assert.IsNull(Res);
        }

        [TestMethod]
        public void TestPairArray()
        {
            Value = ExpectedValue = ExistentItem;
            int[] arr = new int[] { 12, 13, 14, 20, 25, 30, 33, 50, 57, 99 };
            Res = BinarySearch.Search(Arr, Value);
            Assert.AreEqual(ExpectedValue, Res);
        }

        [TestMethod]
        public void TestOddArray()
        {
            Value = 0;
            int[] arr = new int[] { 12, 13, 14, 20, 25, 30, 33, 50, 57};
            Res = BinarySearch.Search(Arr, Value);
            Assert.AreEqual(ExpectedValue, Res);
        }
    }
}
